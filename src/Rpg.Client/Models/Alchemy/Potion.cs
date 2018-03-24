using System.Collections.Generic;

namespace Rpg.Client.Models.Alchemy
{
    public class PotionResponse
    {
        public Potion Potion { get; set; }
    }

    public class Potion
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }

        public IEnumerable<string> Effects { get; set; }
    }
}