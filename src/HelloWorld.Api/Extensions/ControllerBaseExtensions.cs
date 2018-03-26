using HelloWorld.Api.ActionResults;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Extensions
{
    public static class ControllerBaseExtensions
    {
        public static InternalServerErrorObjectResult InternalServerError(this ControllerBase source)
        {
            return new InternalServerErrorObjectResult();
        }
    }
}
