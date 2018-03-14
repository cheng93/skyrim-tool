using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class FortifyCarryWeightAlchemyEffect : AlchemyEffect<FortifyCarryWeightEffect>
    {
        public FortifyCarryWeightAlchemyEffect(
            FortifyCarryWeightEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = "Fortify Carry Weight";
            Description = $"Carrying capacity increases by {Magnitude} for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }
}