using Rpg.Models.Effects;
using Rpg.Models.Effects.Illusion;

namespace Rpg.Models.Alchemy.Effects
{
    public class InvisibilityAlchemyEffect : AlchemyEffect<InvisibilityEffect>
    {
        public InvisibilityAlchemyEffect()
        {
        }

        public InvisibilityAlchemyEffect(
            InvisibilityEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = "Invibility";
            Description = $"Invisibility for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        public override string Id { get; } = "0003EB3D";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly InvisibilityAlchemyEffect Invisibility = new InvisibilityAlchemyEffect(
            AllEffects.Illusion.Invisibility,
            cost: 100,
            duration: 4,
            magnitude: 0
        );
    }
}