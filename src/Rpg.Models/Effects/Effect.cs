namespace Rpg.Models.Effects
{
    public interface IEffect<T> {}

    public abstract class Effect<T> : IEffect<T>
        where T : Effect<T>
    {
        protected Effect(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}