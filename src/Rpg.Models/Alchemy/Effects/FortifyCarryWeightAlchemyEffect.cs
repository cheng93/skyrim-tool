using Rpg.Models.Effects;
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

        public override string Id { get; } = "0003EB01";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly FortifyCarryWeightAlchemyEffect FortifyCarryWeight = new FortifyCarryWeightAlchemyEffect(
            AllEffects.Restoration.FortifyCarryWeight,
            cost: 0.15,
            duration: 300,
            magnitude: 4
        );
    }
}