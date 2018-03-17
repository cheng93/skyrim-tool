using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal class FortifyConjurationIngredientPriority : EffectIngredientPriority<FortifySkillAlchemyEffect>
    {
        private static Dictionary<IIngredient, int> ingredientMap = new Dictionary<IIngredient, int>()
        {
            {AllIngredients.BeritsAshes, 0},
            {AllIngredients.BlueButterflyWing, 0},
            {AllIngredients.BlueMountainFlower, 0},
            {AllIngredients.BoneMeal, 0},
            {AllIngredients.FrostSalts, 0},
            {AllIngredients.HagravenFeathers, 0},
            {AllIngredients.Lavender, 0}
        };

        protected override Dictionary<IIngredient, int> IngredientMap => ingredientMap;
    }
}