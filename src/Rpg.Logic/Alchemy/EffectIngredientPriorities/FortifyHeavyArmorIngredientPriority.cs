using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyHeavyArmorIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.IceWraithTeeth, 0},
            {AllIngredients.SabreCatTooth, 0},
            {AllIngredients.SlaughterfishScales, 0},
            {AllIngredients.ThistleBranch, 0},
            {AllIngredients.WhiteCap, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}