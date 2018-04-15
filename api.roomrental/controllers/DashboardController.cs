using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.roomrental.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.roomrental.controllers
{
    [Produces("application/json")]
    [Authorize(Policy = Constants.Strings.Policy.ApiUser)]
    [Route("api/dashboard")]
    public class DashboardController : Controller
    {

        [HttpGet()]
        public IActionResult GetDashBoardData()
        {

            return Ok();

        }



    }
}