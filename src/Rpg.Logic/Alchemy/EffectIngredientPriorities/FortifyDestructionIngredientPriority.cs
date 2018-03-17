using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyDestructionIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BeehiveHusk, 0},
            {AllIngredients.GlowDust, 0},
            {AllIngredients.GlowingMushroom, 0},
            {AllIngredients.WispWrappings, 0},
            {AllIngredients.Ectoplasm, -10},
            {AllIngredients.Nightshade, -10}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}