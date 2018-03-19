using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Rpg.Commands.Alchemy.ViewModels;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Commands.Alchemy
{
    public class ListIngredients
    {
        public class Response
        {
            internal Response(IEnumerable<IngredientViewModel> ingredients)
            {
                Ingredients = ingredients;
            }

            IEnumerable<IngredientViewModel> Ingredients { get; }
        }

        public class Command : IRequest<Response>
        {
        }

        public class CommandHandler : RequestHandler<Command, Response>
        {
            protected override Response HandleCore(Command request)
            {
                var ingredients = AllIngredients.List.Select(x => new IngredientViewModel(x.Id, x.Name));

                return new Response(ingredients);
            }
        }
    }
}