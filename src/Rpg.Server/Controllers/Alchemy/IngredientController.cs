using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rpg.Commands.Alchemy;

namespace Rpg.Server.Controllers.Alchemy
{
    [Route("api/alchemy/ingredients")]
    public class IngredientController : BaseController
    {
        public IngredientController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> IngredientList()
        {
            var command = new IngredientList.Command();
            var response = await Mediator.Send(command);

            return Json(response);
        }
    }
}