using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class FortifyCarryWeightAlchemyEffect : AlchemyEffect<FortifyCarryWeightEffect>
    {
        public FortifyCarryWeightAlchemyEffect(
            FortifyCarryWeightEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
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
        internal static FortifyCarryWeightAlchemyEffect Create(this FortifyCarryWeightAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new FortifyCarryWeightAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly FortifyCarryWeightAlchemyEffect FortifyCarryWeight = new FortifyCarryWeightAlchemyEffect(
            AllEffects.Restoration.FortifyCarryWeight,
            cost: 0.15M,
            duration: 300,
            magnitude: 4
        );
    }
}