using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Api
{
    /// <summary>应用程序配置信息
    /// </summary>
    public class AppSettings
    {
        /// <summary>数据库连接 
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>事件总线连接
        /// </summary>
        public string EventBusConnection { get; set; }
    }
}
