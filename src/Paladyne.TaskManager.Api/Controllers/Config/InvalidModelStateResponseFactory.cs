using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Paladyne.TaskManager.Api.Extensions;
using Paladyne.TaskManager.Api.Resources;

namespace Paladyne.TaskManager.Api.Controllers.Config
{
    public static class InvalidModelStateResponseFactory
    {
        public static IActionResult ProduceErrorResponse(ActionContext context)
        {
            var errors = context.ModelState.GetErrorMessages();
            var response = new ErrorResource(messages: errors);
            
            return new BadRequestObjectResult(response);
        }
    }
}