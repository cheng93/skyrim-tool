namespace Rpg.Client.Models.Alchemy
{
    public class IngredientsResponse
    {
        public Ingredient[] Ingredients { get; set; }
    }

    public class Ingredient
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}