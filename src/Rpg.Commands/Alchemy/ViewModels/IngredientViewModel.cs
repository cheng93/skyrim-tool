using System.Collections.Generic;

namespace Rpg.Commands.Alchemy.ViewModels
{
    public class IngredientViewModel
    {
        internal IngredientViewModel()
        {

        }

        public string Id { get; internal set; }

        public string Name { get; internal set; }

        public IEnumerable<string> Effects { get; internal set; }
    }
}