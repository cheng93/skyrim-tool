using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using Rpg.Models.Alchemy.Ingredients;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Logic.Alchemy
{
    public class AlchemyOptionsValidator : AbstractValidator<IAlchemyOptions>
    {
        public AlchemyOptionsValidator()
        {
            this.RuleFor(x => x.Ingredients)
                .Must(ValidateIngredients);

            this.RuleFor(x => x.Perks)
                .Must(ValidatePerks);
        }

        private static bool ValidateIngredients(IEnumerable<IIngredient> ingredients)
        {
            if (ingredients == null)
            {
                return false;
            }

            var ingredientsList = ingredients as ICollection<IIngredient> ?? ingredients.ToList();
            return ingredientsList.Count == 2 || ingredientsList.Count == 3;
        }

        private static bool ValidatePerks(IEnumerable<IPerk<AlchemySkill>> perks)
        {
            return perks
                .GroupBy(x => x.GetType())
                .All(x => x.Count() == 1);
        }
    }
}