using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet, Route("")]
        public IActionResult GetSomething()
        {
            throw new IOException();
        }

        [HttpPost, Route("")]
        public IActionResult PostSomething()
        {
            throw new IOException();
        }

        [HttpPut, Route("")]
        public IActionResult PutSomething()
        {
            throw new IOException();
        }

        [HttpDelete, Route("")]
        public IActionResult DeleteSomething()
        {
            throw new IOException();
        }

    }
}
