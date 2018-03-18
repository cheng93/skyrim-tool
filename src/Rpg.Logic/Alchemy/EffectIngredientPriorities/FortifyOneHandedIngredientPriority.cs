using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyOneHandedIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BearClaws, 0},
            {AllIngredients.CanisRoot, 0},
            {AllIngredients.HangingMoss, 0},
            {AllIngredients.HawkFeathers, 0},
            {AllIngredients.RockWarblerEgg, 0},
            {AllIngredients.SmallPearl, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}