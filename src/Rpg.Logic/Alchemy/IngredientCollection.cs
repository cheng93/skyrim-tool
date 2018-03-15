using System;
using System.Collections;
using System.Collections.Generic;
using Rpg.Models.Alchemy;
using Rpg.Models.Alchemy.Ingredients;

namespace Rpg.Logic.Alchemy
{
    public interface IIngredientCollection : IEnumerable<IIngredient>
    {
        void Add(IIngredient ingredient);
    }

    public class IngredientCollection : IIngredientCollection
    {
        private List<IIngredient> ingredients = new List<IIngredient>(3);

        public IEnumerator<IIngredient> GetEnumerator() => ingredients.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Add(IIngredient ingredient)
        {
            if (ingredients.Count >= 3) {
                throw new InvalidOperationException();
            }

            ingredients.Add(ingredient);
        }
    }
}