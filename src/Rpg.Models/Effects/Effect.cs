using Rpg.Models.Common;

namespace Rpg.Models.Effects
{
    public interface IEffect<T> {}

    public abstract class Effect<T> : IEffect<T>, IHasName
        where T : Effect<T>
    {
        protected Effect(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}