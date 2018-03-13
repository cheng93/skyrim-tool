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
    }
}