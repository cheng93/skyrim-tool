namespace Rpg.Models.Effects
{
    public abstract class Effect
    {
        protected Effect(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}