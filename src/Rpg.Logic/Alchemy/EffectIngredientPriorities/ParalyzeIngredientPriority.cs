using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class ParalyzeIngredientPriority : EffectIngredientPriority<ParalyzeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BriarHeart, 0},
            {AllIngredients.CanisRoot, 0},
            {AllIngredients.HumanFlesh, 0},
            {AllIngredients.ImpStool, 0},
            {AllIngredients.SwampFungalPod, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}