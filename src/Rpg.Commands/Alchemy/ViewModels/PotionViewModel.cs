using System.Collections.Generic;

namespace Rpg.Commands.Alchemy.ViewModels
{
    public class PotionViewModel
    {
        internal PotionViewModel()
        {

        }

        public string Name { get; internal set; }

        public decimal Cost { get; internal set; }

        public IEnumerable<string> Effects { get; internal set; }
    }
}