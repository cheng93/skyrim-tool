using Rpg.Models.Effects;
using Rpg.Models.Effects.Alteration;

namespace Rpg.Models.Alchemy.Effects
{
    public class ParalyzeAlchemyEffect : AlchemyEffect<ParalyzeEffect>
    {
        public ParalyzeAlchemyEffect()
        {
        }

        public ParalyzeAlchemyEffect(
            ParalyzeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name { get; } = "Paralysis";

        public override string Description => $"Target is paralyzed for {Duration} seconds.";

        public override string Id { get; } = "00073F30";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly ParalyzeAlchemyEffect Paralyze = new ParalyzeAlchemyEffect(
            AllEffects.Alteration.Paralyze,
            cost: 500,
            duration: 1,
            magnitude: 0
        );
    }
}