using Rpg.Models.Effects;
using Rpg.Models.Effects.Illusion;

namespace Rpg.Models.Alchemy.Effects
{
    public class FrenzyAlchemyEffect : AlchemyEffect<FrenzyEffect>
    {
        public FrenzyAlchemyEffect()
        {
        }

        public FrenzyAlchemyEffect(
            FrenzyEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = "Frenzy";
            Description = $"Creatures and people up to level {Magnitude} will attack anything nearby for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        public override string Id { get; } = "00073F29";
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly FrenzyAlchemyEffect Frenzy = new FrenzyAlchemyEffect(
            AllEffects.Illusion.Frenzy,
            cost: 15,
            duration: 10,
            magnitude: 1
        );
    }
}