using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rpg.Commands.Alchemy;

namespace Rpg.Web.Controllers.Alchemy
{
    [Route("api/alchemy/potion")]
    public class PotionController : BaseController
    {
        public PotionController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]PotionCreate.Command command)
        {
            var response = await Mediator.Send(command);

            return Json(response);
        }
    }
}