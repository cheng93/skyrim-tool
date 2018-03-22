using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using MediatR;
using Rpg.Commands.Alchemy.ViewModels;
using Rpg.Commands.Pipeline;
using Rpg.Logic.Alchemy;
using Rpg.Logic.Common.Constants;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Perks.Alchemy;

namespace Rpg.Commands.Alchemy
{
    public class PotionCreate
    {
        public class Response
        {
            internal Response(PotionViewModel potion)
            {
                Potion = potion;
            }

            public PotionViewModel Potion { get; }
        }

        public class Command : IRequest<Response>
        {
            public int AlchemyLevel { get; set; } = 15;

            public int AlchemistPerkRank { get; set; }

            public decimal FortifyAlchemyPercent { get; set; }

            public bool HasBenefactorPerk { get; set; }

            public bool HasPhysicianPerk { get; set; }

            public bool HasPoisonerPerk { get; set; }

            public IEnumerable<string> IngredientIds { get; set; } = Enumerable.Empty<string>();
        }

        public class Validator : ValidationPreProcessor<Command>
        {
            public Validator()
            {
                this.RuleFor(x => x.AlchemyLevel)
                    .InclusiveBetween(SkillConstants.MinLevel, SkillConstants.MaxLevel);

                this.RuleFor(x => x.AlchemistPerkRank)
                    .InclusiveBetween(0, 5);

                this.RuleFor(x => x.IngredientIds)
                    .NotNull();

                this.RuleFor(x => x.IngredientIds.Count())
                    .InclusiveBetween(2, 3)
                    .WithName("Ingredient Ids Length");

                var ingredientDict = AllIngredients.List.ToDictionary(x => x.Id);
                this.RuleForEach(x => x.IngredientIds)
                    .Must(x => ingredientDict.ContainsKey(x))
                    .WithMessage((command, id) => $"'{id}' is an invalid ingredient id.");
            }
        }

        public class CommandHandler : RequestHandler<Command, Response>
        {
            public CommandHandler(IPotionBuilderFactory potionBuilderFactory)
            {
                this.potionBuilderFactory = potionBuilderFactory;
            }

            private readonly IPotionBuilderFactory potionBuilderFactory;

            protected override Response HandleCore(Command request)
            {
                var ingredientDict = AllIngredients.List.ToDictionary(x => x.Id);

                var ingredients = request.IngredientIds.Select(x => ingredientDict[x]);

                var potionBuilder = potionBuilderFactory.Create();

                foreach (var ingredient in ingredients)
                {
                    potionBuilder = potionBuilder.Ingredient(ingredient);
                }

                if (alchemistMap[request.AlchemistPerkRank] != null)
                {
                    potionBuilder = potionBuilder.Perk(alchemistMap[request.AlchemistPerkRank]);
                }

                if (request.HasBenefactorPerk)
                {
                    potionBuilder = potionBuilder.Perk(AllPerks.Alchemy.Benefactor);
                }

                if (request.HasPhysicianPerk)
                {
                    potionBuilder = potionBuilder.Perk(AllPerks.Alchemy.Physician);
                }

                if (request.HasPoisonerPerk)
                {
                    potionBuilder = potionBuilder.Perk(AllPerks.Alchemy.Poisoner);
                }

                var potion = potionBuilder
                    .AlchemyLevel(request.AlchemyLevel)
                    .FortifyAlchemyPercent(request.FortifyAlchemyPercent)
                    .Validate()
                    .Build();

                return new Response(new PotionViewModel
                {
                    Name = potion.Name,
                    Cost = potion.Cost,
                    Effects = potion.Effects.Select(x => x.Description)
                });
            }

            private static readonly Dictionary<int, AlchemistPerk> alchemistMap 
                = new Dictionary<int, AlchemistPerk>()
            {
                {0, null},
                {1, AllPerks.Alchemy.Alchemist.One},
                {2, AllPerks.Alchemy.Alchemist.Two},
                {3, AllPerks.Alchemy.Alchemist.Three},
                {4, AllPerks.Alchemy.Alchemist.Four},
                {5, AllPerks.Alchemy.Alchemist.Five}
            };
        }
    }
}