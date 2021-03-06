using System.Collections.Generic;
using System.Linq;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Common;

namespace Rpg.Models.Alchemy
{
    public interface IPotion : IHasName, IHasDescription
    {
        decimal Cost { get; }

        IEnumerable<IAlchemyEffect> Effects { get; }
    }

    public class Potion : IPotion
    {
        public Potion(
            IEnumerable<IAlchemyEffect> effects,
            string name)
        {
            Effects = effects;
            Name = name;
            Description = string.Join(" ", effects.Select(x => x.Description));
            Cost = effects.Sum(x => x.Cost);

        }

        public decimal Cost { get; }

        public IEnumerable<IAlchemyEffect> Effects { get; }

        public string Name { get; }

        public string Description { get; }
    }
}