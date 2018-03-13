using Rpg.Models.Effects.Illusion;

namespace Rpg.Models.Alchemy.Effects
{
    public class FrenzyAlchemyEffect : AlchemyEffect<FrenzyEffect>
    {
        public FrenzyAlchemyEffect(
            FrenzyEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = "Frenzy";
            Description = $"Creatures and people up to level {Magnitude} will attack anything nearby for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}