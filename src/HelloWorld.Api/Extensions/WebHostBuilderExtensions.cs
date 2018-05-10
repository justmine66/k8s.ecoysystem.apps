using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloWorld.Api.Extensions
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseConfigrationWithDir(this IWebHostBuilder hostBuilder, params string[] relativePaths)
        {
            return hostBuilder.ConfigureAppConfiguration((Action<WebHostBuilderContext, IConfigurationBuilder>)((hostingContext, config) =>
               {
                   string configFileDir = String.Empty;

                   if (relativePaths != null && relativePaths.Any())
                   {
                       foreach (var path in relativePaths)
                       {
                           if(string.IsNullOrWhiteSpace(path)) throw new ArgumentException("配置文件目录路径不合法: "+nameof(path));

                           configFileDir = Path.Combine(configFileDir, path);
                       }

                       if (!string.IsNullOrEmpty(configFileDir))
                       {
                           configFileDir = configFileDir + @"\";
                       }
                   }

                   IHostingEnvironment env = hostingContext.HostingEnvironment;
                   config
                       .AddJsonFile($"{configFileDir}appsettings.json", true, true)
                       .AddJsonFile($"{configFileDir}appsettings.{env.EnvironmentName}.json", true,true);
               }));
        }
    }
}
