using Microsoft.AspNetCore.Mvc;
using System;

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
