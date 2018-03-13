using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class ResistMagicAlchemyEffect : AlchemyEffect<ResistMagicEffect>
    {
        public ResistMagicAlchemyEffect(
            ResistMagicEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = "Resist Magic";
            Description = $"Resist {Magnitude}% of magic for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}