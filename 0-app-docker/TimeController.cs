using System;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("api/time")]
    public class TimeController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new
            {
                Version = "V1",
                Time = DateTime.UtcNow.ToString()
            });
        }
    }
}