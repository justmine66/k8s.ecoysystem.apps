using HealthChecks.Api.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace HealthChecks.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    public class HeathChecksController : Controller
    {
        private readonly static DateTime _beginUtc = DateTime.UtcNow;

        /// <summary>存活性
        /// </summary>
        /// <remarks>
        /// The kubelet uses liveness probes to know when to restart a Container. 
        /// </remarks>
        /// <returns>Any code greater than or equal to 200 and less than 400 indicates success. Any other code indicates failure.</returns>
        // GET api/v1/heathchecks/liveness
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.ServiceUnavailable)]
        [Route("liveness")]
        public async Task<IActionResult> Liveness()
        {
            return await Task.Run<IActionResult>(() =>
            {
                //存活10分钟
                //探测失败，将重启容器，进入自愈阶段。
                if (DateTime.UtcNow.Subtract(_beginUtc).TotalSeconds > 60 * 10)
                {
                    Console.WriteLine("{0} HealthChecks.Api is dead, start restarting...", DateTime.Now);
                    return this.InternalServerError();
                }
                else
                {
                    Console.WriteLine("{0} HealthChecks.Api is alive.", DateTime.Now);
                    return this.Ok();
                }
            });
        }
        /// <summary>准备就绪
        /// </summary>
        /// <remarks>The kubelet uses readiness probes to know when a Container is ready to start accepting traffic.</remarks>
        /// <returns>Any code greater than or equal to 200 and less than 400 indicates success. Any other code indicates failure.</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.ServiceUnavailable)]
        [Route("readiness")]
        public async Task<IActionResult> Readiness()
        {
            return await Task.Run<IActionResult>(() =>
            {
                //等待30秒准备就绪
                //应用启动通常都需要一个准备阶段，比如加载缓存数据，连接数据库等，从容器启动到正真能够提供服务是需要一段时间的。
                if (DateTime.UtcNow.Subtract(_beginUtc).TotalSeconds < 30)
                {
                    Console.WriteLine("{0} HealthChecks.Api is not ready...", DateTime.Now);
                    return this.InternalServerError();
                }
                else
                {
                    Console.WriteLine("{0} HealthChecks.Api is ready, start accepting traffic...", DateTime.Now);
                    return this.Ok();
                }
            });
        }
    }
}
