using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class WeaknessToFireIngredientPriority : EffectIngredientPriority<WeaknessToElementAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BleedingCrown, 0},
            {AllIngredients.FrostSalts, 0},
            {AllIngredients.IceWraithTeeth, 0},
            {AllIngredients.JuniperBerries, 0},
            {AllIngredients.MoonSugar, 0},
            {AllIngredients.PowderedMammothTusk, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}