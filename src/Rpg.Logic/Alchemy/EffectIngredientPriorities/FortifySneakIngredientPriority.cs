using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifySneakIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.AbeceanLongfin, 0},
            {AllIngredients.BeehiveHusk, 0},
            {AllIngredients.FrostMirriam, 0},
            {AllIngredients.HawkFeathers, 0},
            {AllIngredients.HumanFlesh, 0},
            {AllIngredients.PowderedMammothTusk, 0},
            {AllIngredients.PurpleMountainFlower, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}