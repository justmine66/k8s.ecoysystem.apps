using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    public class HelloWorldController : Controller
    {
        // GET api/v1/helloworld
        [HttpGet]
        public string Get()
        {
            string msg = string.Format("{0} hello world!", DateTime.Now);
            Console.WriteLine(msg);
            return msg;
        }
    }
}
