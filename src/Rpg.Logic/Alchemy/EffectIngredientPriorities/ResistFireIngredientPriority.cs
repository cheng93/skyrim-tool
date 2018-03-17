using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class ResistFireIngredientPriority : EffectIngredientPriority<ResistElementAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BeritsAshes, 0},
            {AllIngredients.BoneMeal, 0},
            {AllIngredients.DragonsTongue, 0},
            {AllIngredients.ElvesEar, 0},
            {AllIngredients.FireSalts, 0},
            {AllIngredients.FlyAmanita, 0},
            {AllIngredients.MudcrabChitin, 0},
            {AllIngredients.Snowberries, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}