using Rpg.Models.Common;

namespace Rpg.Models.Effects
{
    public interface IEffect<T> : IHasName
        where T : IEffect<T>
    {
    }

    public abstract class Effect<T> : IEffect<T>
        where T : IEffect<T>
    {
        protected Effect(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}