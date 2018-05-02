using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class ResistFrostIngredientPriority : EffectIngredientPriority<ResistElementAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.FrostMirriam, 0},
            {AllIngredients.FrostSalts, 0},
            {AllIngredients.HawkBeak, 0},
            {AllIngredients.MoonSugar, 0},
            {AllIngredients.PurpleMountainFlower, 0},
            {AllIngredients.SilversidePerch, 0},
            {AllIngredients.SlaughterfishScales, 0},
            {AllIngredients.SmallPearl, 0},
            {AllIngredients.Snowberries, 0},
            {AllIngredients.ThistleBranch, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}