using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RosanicSocial.Application.Interfaces;
using RosanicSocial.Application.Interfaces.DbServices;
using RosanicSocial.Domain.Data.Identity;
using RosanicSocial.Domain.DTO.Request.Account;
using RosanicSocial.Domain.DTO.Request.Info.Base;
using RosanicSocial.Domain.DTO.Request.Info.Detailed;
using RosanicSocial.Domain.DTO.Response.Authentication;
using RosanicSocial.Domain.DTO.Response.Info.Base;
using RosanicSocial.Domain.DTO.Response.Info.Detailed;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Application.Services.DbServices {
    public class AccountDbService : IAccountDbService {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IJwtService _jwtService;
        private readonly IUserInfoDbService _userInfoDbService;

        private readonly ILogger<AccountDbService> _logger; 
        public AccountDbService(ILogger<AccountDbService> logger, UserManager<ApplicationUser> userManger, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService, IUserInfoDbService userInfoDbService) {
            _userManager = userManger;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _jwtService = jwtService;
            _userInfoDbService = userInfoDbService;
            _logger = logger;
        }

        public async Task<ApplicationUser?> IsUsernameAlreadyRegistered(string username) {
            return await _userManager.FindByNameAsync(username);
        }

        public async Task<ApplicationUser?> Login(LoginRequest request) {
            Microsoft.AspNetCore.Identity.SignInResult result =
                await _signInManager.PasswordSignInAsync(
                    request.UserName, request.Password, isPersistent: false, lockoutOnFailure: true);

            if (result.Succeeded) {
                ApplicationUser? user = await _userManager.FindByNameAsync(request.UserName);
                return user;

            } else {
                _logger.LogError("Password and Username not matching");
                return null;
            }
        }

        public async Task Logout() {
            await _signInManager.SignOutAsync();
        }

        public async Task<AuthenticationResponse?> Register(RegisterRequest request) {
            ApplicationUser user = new ApplicationUser() {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                UserName = request.Username
            };

            IdentityResult result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded) {
                await _signInManager.SignInAsync(user, isPersistent: false);

                AuthenticationResponse authResponse = _jwtService.CreateJwtToken(user.ToAuthRequest());

                user.RefreshToken = authResponse.RefreshToken;
                user.RefreshTokenExpiration = authResponse.RefreshTokenExpiration;

                await _userManager.UpdateAsync(user);

                //CreateInfos
                BaseInfoAddResponse baseInfoResponse = await _userInfoDbService.AddBaseInfo(new BaseInfoAddRequest { UserId = user.Id });
                DetailedInfoAddResponse detailedInfoResponse = await _userInfoDbService.AddDetailedInfo(new DetailedInfoAddRequest { UserId = user.Id });

                return authResponse;
            }

            string errorDesc = string.Join(" | ", result.Errors.Select(x => x.Description));
            _logger.LogError(errorDesc);
            return null;
        }
    }
}