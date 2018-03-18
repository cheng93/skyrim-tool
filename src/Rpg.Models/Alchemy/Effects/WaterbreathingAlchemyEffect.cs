using Rpg.Models.Effects;
using Rpg.Models.Effects.Alteration;

namespace Rpg.Models.Alchemy.Effects
{
    public class WaterbreathingAlchemyEffect : AlchemyEffect<WaterbreathingEffect>
    {
        public WaterbreathingAlchemyEffect(
            WaterbreathingEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name { get; } = "Waterbreathing";

        public override string Description => $"Can breathe underwater for {Duration} seconds.";

        public override string Id { get; } = "0003AC2D";
    }

    public static partial class AllAlchemyEffects
    {
        internal static WaterbreathingAlchemyEffect Create(this WaterbreathingAlchemyEffect e, double cost, double duration, double magnitude)
        {
            return new WaterbreathingAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly WaterbreathingAlchemyEffect Waterbreathing = new WaterbreathingAlchemyEffect(
            AllEffects.Alteration.Waterbreathing,
            cost: 30,
            duration: 5,
            magnitude: 0
        );
    }
}