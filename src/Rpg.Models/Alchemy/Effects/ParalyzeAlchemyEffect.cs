using Rpg.Models.Effects;
using Rpg.Models.Effects.Alteration;

namespace Rpg.Models.Alchemy.Effects
{
    public class ParalyzeAlchemyEffect : AlchemyEffect<ParalyzeEffect>
    {
        public ParalyzeAlchemyEffect(
            ParalyzeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = "Paralysis";
            Description = $"Target is paralyzed for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

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