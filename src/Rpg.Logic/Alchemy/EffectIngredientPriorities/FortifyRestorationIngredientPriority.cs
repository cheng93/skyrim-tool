using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyRestorationIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.AbeceanLongfin, 0},
            {AllIngredients.CyrodilicSpadetail, 0},
            {AllIngredients.SaltPile, 0},
            {AllIngredients.SmallAntlers, 0},
            {AllIngredients.SmallPearl, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}