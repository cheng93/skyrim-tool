using Microsoft.AspNetCore.Blazor;
using System;
using System.Collections.Generic;
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

        public bool LoadingPotion{ get; private set; }

        public async Task LoadIngredients()
        {
            LoadingIngredients = true;
            NotifyStateChanged();

            var response = await client.GetJsonAsync<IngredientsResponse>("/api/alchemy/ingredients");
            Ingredients = response.Ingredients;

            LoadingIngredients = false;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}