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

        public int AlchemyLevel { get; private set; } = 15;

        public decimal FortifyAlchemyPercent { get; private set; } = 0M;

        public int AlchemistPerkRank { get; private set; }

        public bool HasBenefactorPerk { get; private set; }

        public bool HasPhysicianPerk { get; private set; }

        public bool HasPoisonerPerk { get; private set; }

        public bool HasPurityPerk { get; private set; }

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

        public void ChangeAlchemyLevel(string number)
        {
            if (int.TryParse(number, out var parsed))
            {
                AlchemyLevel = parsed;
            }
            NotifyStateChanged();
        }

        public void ChangeFortifyAlchemy(string number)
        {
            if (decimal.TryParse(number, out var parsed))
            {
                FortifyAlchemyPercent = parsed;
            }
            NotifyStateChanged();
        }

        public void ChangeAlchemistRank(string rank)
        {
            AlchemistPerkRank = int.Parse(rank);
            NotifyStateChanged();
        }

        public void ChangeHasBenefactor(bool hasPerk)
        {
            HasBenefactorPerk = hasPerk;
            NotifyStateChanged();
        }

        public void ChangeHasPhysician(bool hasPerk)
        {
            HasPhysicianPerk = hasPerk;
            NotifyStateChanged();
        }

        public void ChangeHasPoisoner(bool hasPerk)
        {
            HasPoisonerPerk = hasPerk;
            NotifyStateChanged();
        }

        public void ChangeHasPurity(bool hasPerk)
        {
            HasPurityPerk = hasPerk;
            NotifyStateChanged();
        }

        public async Task CreatePotion()
        {
            LoadingPotion = true;
            NotifyStateChanged();

            var postData = new 
            {
                AlchemistPerkRank = AlchemistPerkRank,
                AlchemyLevel = AlchemyLevel,
                FortifyAlchemyPercent = FortifyAlchemyPercent,
                HasBenefactorPerk = HasBenefactorPerk,
                HasPhysicianPerk = HasPhysicianPerk,
                HasPoisonerPerk = HasPoisonerPerk,
                HasPurityPerk = HasPurityPerk,
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