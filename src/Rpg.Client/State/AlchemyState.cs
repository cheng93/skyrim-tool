using Microsoft.AspNetCore.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Rpg.Client.Models.Alchemy;

namespace Rpg.Client.State
{
    public class AlchemyState
    {
        public AlchemyState(HttpClient client)
        {
            this.client = client;
        }

        private readonly HttpClient client;

        public event Action OnChange;

        public bool LoadingIngredients { get; private set; }

        public Ingredient[] Ingredients { get; private set; }

        private Dictionary<string, Ingredient> ingredientDict;

        public bool LoadingPotion { get; private set; }

        public Ingredient IngredientOne { get; private set; }

        public Ingredient IngredientTwo { get; private set; }

        public Ingredient IngredientThree { get; private set; }

        private IEnumerable<string> SelectedIngredientIds
            => new []
            {
                IngredientOne,
                IngredientTwo,
                IngredientThree
            }
            .Where(x => x != null)
            .Select(x => x.Id);

        public Potion Potion { get; private set; }

        public async Task LoadIngredients()
        {
            LoadingIngredients = true;
            NotifyStateChanged();

            var response = await client.GetJsonAsync<IngredientsResponse>("/api/alchemy/ingredients");
            Ingredients = response.Ingredients;
            ingredientDict = Ingredients.ToDictionary(x => x.Id);

            LoadingIngredients = false;
            NotifyStateChanged();
        }

        public void ChangeIngredientOne(string ingredientId)
        { 
            IngredientOne = GetIngredient(ingredientId);
            NotifyStateChanged();
        }

        public void ChangeIngredientTwo(string ingredientId)
        {
            IngredientTwo = GetIngredient(ingredientId);
            NotifyStateChanged();
        }

        public void ChangeIngredientThree(string ingredientId)
        {
            IngredientThree = GetIngredient(ingredientId);
            NotifyStateChanged();
        }

        public async Task CreatePotion()
        {
            LoadingPotion = true;
            NotifyStateChanged();

            var postData = new 
            {
                IngredientIds = SelectedIngredientIds
            };

            var response = await client.PostJsonAsync<PotionResponse>("/api/alchemy/potion", postData);
            Potion = response.Potion;

            LoadingPotion = false;
            NotifyStateChanged();
        }

        private Ingredient GetIngredient(string ingredientId)
        {
            ingredientDict.TryGetValue(ingredientId, out var ingredient);
            return ingredient;
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}