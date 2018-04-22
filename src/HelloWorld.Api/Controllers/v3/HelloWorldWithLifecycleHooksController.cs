using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers.v1
{
    [Route("api/v3/helloworld")]
    public class HelloWorldWithLifecycleHooksController : Controller
    {
        // GET api/v3/helloworld
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string msg = string.Format("{0} hello world!", DateTime.Now);
            Console.WriteLine(msg);
            return new string[] { msg};     
        }
    }
}
