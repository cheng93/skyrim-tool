using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Rpg.Server.Setup.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await this.next(context);
            }
            catch(ValidationException e)
            {
                var errors = new {
                    errors = e.Errors.Select(x => x.ToString())
                };
                
                await context.Response.WriteAsync(JsonConvert.SerializeObject(errors));
            }
        }
    }
}