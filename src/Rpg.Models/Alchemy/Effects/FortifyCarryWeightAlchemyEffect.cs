using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class FortifyCarryWeightAlchemyEffect : AlchemyEffect<FortifyCarryWeightEffect>
    {
        public FortifyCarryWeightAlchemyEffect()
        {
        }

        public FortifyCarryWeightAlchemyEffect(
            FortifyCarryWeightEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name { get; } = "Fortify Carry Weight";

        public override string Description => $"Carrying capacity increases by {Magnitude} for {Duration} seconds.";

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