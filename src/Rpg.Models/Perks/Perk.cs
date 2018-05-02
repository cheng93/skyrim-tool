using Rpg.Models.Common;
using Rpg.Models.Skills;

namespace Rpg.Models.Perks
{
    public interface IPerk<T> : IHasName, IHasDescription
        where T : ISkill
    {
    }

    public abstract class Perk<T> : IPerk<T>
        where T : ISkill
    {
        protected Perk(string name)
        {
            Name = name;
        }

        public abstract string Description { get; }

        public string Name { get; }
    }
}