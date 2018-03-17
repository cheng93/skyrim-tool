using Rpg.Models.Effects;
using Rpg.Models.Effects.Alteration;

namespace Rpg.Models.Alchemy.Effects
{
    public class WaterbreathingAlchemyEffect : AlchemyEffect<WaterbreathingEffect>
    {
        public WaterbreathingAlchemyEffect()
        {
        }

        public WaterbreathingAlchemyEffect(
            WaterbreathingEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = "Waterbreathing";
            Description = $"Can breathe underwater for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        public override string Id { get; } = "0003AC2D";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly WaterbreathingAlchemyEffect Waterbreathing = new WaterbreathingAlchemyEffect(
            AllEffects.Alteration.Waterbreathing,
            cost: 30,
            duration: 5,
            magnitude: 0
        );
    }
}