using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class CureDiseaseAlchemyEffect : AlchemyEffect<CureDiseaseEffect>
    {
        public CureDiseaseAlchemyEffect(
            CureDiseaseEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name { get; } = "Cure Disease";

        public override string Description { get; } = "Cures all diseases.";

        public override string Id { get; } = "000AE722";
    }

    public static partial class AllAlchemyEffects
    {
        internal static CureDiseaseAlchemyEffect Create(this CureDiseaseAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new CureDiseaseAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly CureDiseaseAlchemyEffect CureDisease = new CureDiseaseAlchemyEffect(
            AllEffects.Restoration.CureDisease,
            cost: 0.5M,
            duration: 0,
            magnitude: 5
        );
    }
}