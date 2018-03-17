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
        private readonly DateTime _beginUtc = DateTime.UtcNow;

        /// <summary>存活
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
                //轮询存活，间隔60秒
                if (DateTime.UtcNow.Subtract(_beginUtc).TotalSeconds % 60 == 0)
                {
                    Console.WriteLine("{0} HealthChecks.Api is dead, start restrating.", DateTime.Now);
                    return this.InternalServerError();
                }
                else
                {
                    Console.WriteLine("{0} HealthChecks.Api is alive", DateTime.Now);
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
                //轮询准备就绪，间隔60秒
                if (DateTime.UtcNow.Subtract(_beginUtc).TotalSeconds % 60 == 0)
                {
                    Console.WriteLine("{0} HealthChecks.Api is ready,start accepting traffic.", DateTime.Now);
                    return this.InternalServerError();
                }
                else
                {
                    Console.WriteLine("{0} HealthChecks.Api is not ready", DateTime.Now);
                    return this.Ok();
                }
            });
        }
    }
}
