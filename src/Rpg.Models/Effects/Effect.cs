using Rpg.Models.Common;

namespace Rpg.Models.Effects
{
    public interface IEffect : IHasName
    {
    }

    public abstract class Effect : IEffect
    {
        protected Effect(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}