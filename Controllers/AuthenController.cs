using System;
using System.Data;
using System.Net.Cache;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;
using SampleTemplate.InitialAppSettings;
using SampleTemplate.Models;

namespace SampleTemplate.Controllers{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public class AuthenController : ControllerBase {
        AppSettings config;
        SampleModel sample;
        ResponseModel res;
        public AuthenController(IOptions<AppSettings> initial)
        {
            config = initial.Value;
            sample = new SampleModel(initial);
            res = new ResponseModel();
        } 

        [HttpGet]
        public IActionResult get()
        {
            return Ok(config.ConnectionStrings.prod);
        }

        [HttpPost]
        public IActionResult post(string agreementNo)
        {
            try
            {
                res = sample.InitialState(agreementNo);
                if(res.data.Rows.Count == 0)
                {
                    return NotFound(res);
                }
            }
            catch(Exception e)
            {
                return BadRequest(res);
            }
            

            return Ok(res);
        }
    }
}