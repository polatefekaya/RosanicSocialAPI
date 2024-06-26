﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using RosanicSocial.Application.Interfaces;
using RosanicSocial.Application.Interfaces.Creators;
using RosanicSocial.Application.Interfaces.DbServices;
using RosanicSocial.Application.Interfaces.Factories;
using RosanicSocial.Application.Interfaces.Helpers;
using RosanicSocial.Application.Interfaces.Helpers.Managers;
using RosanicSocial.Application.Interfaces.Managers;
using RosanicSocial.Application.Interfaces.Repository;
using RosanicSocial.Application.Services;
using RosanicSocial.Application.Services.Creators;
using RosanicSocial.Application.Services.DbServices;
using RosanicSocial.Application.Services.Factories;
using RosanicSocial.Application.Services.Helpers;
using RosanicSocial.Application.Services.Helpers.Managers;
using RosanicSocial.Application.Services.Managers;

namespace RosanicSocial.Application {
    public static class DependencyInjection {
        public static IServiceCollection AddApplication(this IServiceCollection services) {
            services.AddScoped<IAccountDbService, AccountDbService>();
            services.AddScoped<ICommentDbService, CommentDbService>();
            services.AddScoped<IFollowDbService, FollowDbService>();
            services.AddScoped<ILikeDbService, LikeDbService>();
            services.AddScoped<IPostDbService, PostDbService>();
            services.AddScoped<IUserInfoDbService, UserInfoDbService>();
            services.AddScoped<IDbTableCreatorFactoryService, DbTableCreatorFactoryService>();
            services.AddScoped<IDbTableCreatorService, DbTableCreatorService>();
            services.AddTransient<IJwtService, JwtService>();
            services.AddTransient<IJwtHelperService, JwtHelperService>();
            services.AddScoped<IEntityConvertService, EntityConvertService>();

            services.AddScoped<IUserBlockDbService, UserBlockDbService>();

            services.AddScoped<ISharingsDbManagerService, SharingsDbManagerService>();
            services.AddScoped<IInteractionDbManagerService, InteractionDbManagerService>();
            services.AddScoped<IInteractionDbManagerHelperService, InteractionDbManagerHelperService>();

            services.AddTransient<IEmailSenderService, EmailSenderService>();

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            return services;
        }
    }
}
