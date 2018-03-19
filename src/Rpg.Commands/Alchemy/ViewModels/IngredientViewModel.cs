namespace Rpg.Commands.Alchemy.ViewModels
{
    public class IngredientViewModel
    {
        public IngredientViewModel(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; }

        public string Name { get; }
    }
}