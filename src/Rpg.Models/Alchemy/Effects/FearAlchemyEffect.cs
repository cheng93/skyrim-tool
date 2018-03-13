using Rpg.Models.Effects.Illusion;

namespace Rpg.Models.Alchemy.Effects
{
    public class FearAlchemyEffect : AlchemyEffect<FearEffect>
    {
        public FearAlchemyEffect(
            FearEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = "Fear";
            Description = $"Creatures and people up to level {Magnitude} flee from combat for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}