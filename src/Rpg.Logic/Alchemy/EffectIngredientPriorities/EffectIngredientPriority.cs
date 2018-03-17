using System.Collections.Generic;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy.EffectIngredientPriorities
{
    internal interface IEffectIngredientPriority
    {
        int GetPriority(IIngredient ingredient);
    }

    internal abstract class EffectIngredientPriority<T> : IEffectIngredientPriority
        where T : IAlchemyEffect
    {
        protected abstract Dictionary<IIngredient, int> IngredientMap { get; }

        public int GetPriority(IIngredient ingredient) => IngredientMap[ingredient];
    }
}