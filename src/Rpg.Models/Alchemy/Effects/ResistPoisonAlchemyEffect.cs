using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class ResistPoisonAlchemyEffect : AlchemyEffect<ResistPoisonEffect>
    {
        public ResistPoisonAlchemyEffect(
            ResistPoisonEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = "Resist Poison";
            Description = $"Resist {Magnitude}% of poison for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}