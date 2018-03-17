using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifySmithingIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.Blisterwort, 0},
            {AllIngredients.GlowingMushroom, 0},
            {AllIngredients.SabreCatTooth, 0},
            {AllIngredients.SprigganSap, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}