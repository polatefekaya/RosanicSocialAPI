﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RosanicSocial.Application.Interfaces.DbServices;
using RosanicSocial.Domain.DTO.Request.Rose;
using RosanicSocial.Domain.DTO.Response.Rose;
using RosanicSocial.WebAPI.Models;

namespace RosanicSocial.WebAPI.Controllers.v1
{

    public class RoseController : CustomControllerBase {
        //CreateRose
        //ReadRose
        //UpdateRose
        //DeleteRose
        private readonly IPostDbService _roseDbService;
        public RoseController(IPostDbService roseDbService) {
            _roseDbService = roseDbService;
        }

        [HttpGet]
        public async Task<ActionResult<Rose>> GetRose(Guid Id) {
            //GetFromDataBase
            Rose rose = new Rose();
            RoseGetRequest request = new RoseGetRequest();
            request.Id = Id;
            RoseGetResponse response = await _roseDbService.GetPost(request);
            return rose;
        }

        /*
        [HttpPut]
        public async Task<IActionResult> PutRose() {

        }


        [HttpPost]
        public async ActionResult<Rose> PostRose() {
            Rose rose = new Rose();
            return CreatedAtAction("ReadRose", rose);
        }
        */
    }
}
