using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyLightArmorIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BeehiveHusk, 0},
            {AllIngredients.HawkFeathers, 0},
            {AllIngredients.Honeycomb, 0},
            {AllIngredients.LunaMothWing, 0},
            {AllIngredients.SkeeverTail, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}