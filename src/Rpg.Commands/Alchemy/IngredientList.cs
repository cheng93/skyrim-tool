using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Rpg.Commands.Alchemy.ViewModels;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Commands.Alchemy
{
    public class IngredientList
    {
        public class Response
        {
            internal Response(IEnumerable<IngredientViewModel> ingredients)
            {
                Ingredients = ingredients;
            }

            public IEnumerable<IngredientViewModel> Ingredients { get; }
        }

        public class Command : IRequest<Response>
        {
        }

        public class CommandHandler : RequestHandler<Command, Response>
        {
            protected override Response HandleCore(Command request)
            {
                var ingredients = AllIngredients.List.Select(x => 
                    new IngredientViewModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Effects = new []
                            {
                                x.PrimaryEffect,
                                x.SecondaryEffect,
                                x.TertiaryEffect,
                                x.QuaternaryEffect
                            }
                            .Select(y => y.Description)
                        
                    });

                return new Response(ingredients);
            }
        }
    }
}