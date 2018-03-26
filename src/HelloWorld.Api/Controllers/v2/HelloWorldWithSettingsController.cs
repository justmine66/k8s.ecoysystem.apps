using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace HelloWorld.Api.Controllers.v1
{
    [Route("api/v2/helloworld")]
    public class HelloWorldWithSettingsController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppSettings _settings;

        public HelloWorldWithSettingsController(
            IHostingEnvironment env,
            IOptionsSnapshot<AppSettings> settings)
        {
            _env = env;
            _settings = settings.Value;
        }

        // GET api/v2/helloworld/settings
        [HttpGet]
        [Route("settings")]
        public IEnumerable<string> Get()
        {
            var results = new string[] {
                $"{DateTime.Now}",
                $"{_env.ApplicationName}",
                $"{_env.EnvironmentName}",
                $"数据库连接字符串: {_settings.ConnectionString}",
                $"事件总线连接字符串: {_settings.EventBusConnection}"
            };

            return results;
        }
    }
}
