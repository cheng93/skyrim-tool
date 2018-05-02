using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class RegenerateHealthIngredientPriority : EffectIngredientPriority<RegenerateAttributeAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.Garlic, 0},
            {AllIngredients.JuniperBerries, 0},
            {AllIngredients.LunaMothWing, 0},
            {AllIngredients.NamirasRot, 0},
            {AllIngredients.NordicBarnacle, 0},
            {AllIngredients.VampireDust, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}