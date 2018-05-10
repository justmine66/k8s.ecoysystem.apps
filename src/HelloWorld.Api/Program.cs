using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using HelloWorld.Api.Extensions;

namespace HelloWorld.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder()
                .UseConfigrationWithDir("configrations")
                .UseStartup<Startup>()
                .Build();
    }
}
