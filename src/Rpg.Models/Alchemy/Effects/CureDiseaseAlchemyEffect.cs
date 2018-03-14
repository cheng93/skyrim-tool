using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;

namespace Rpg.Models.Alchemy.Effects
{
    public class CureDiseaseAlchemyEffect : AlchemyEffect<CureDiseaseEffect>
    {
        public CureDiseaseAlchemyEffect(
            CureDiseaseEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = "Cure Disease";
            Description = "Cures all diseases.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }

    public partial class AllAlchemyEffects
    {
        public static readonly CureDiseaseAlchemyEffect CureDisease = new CureDiseaseAlchemyEffect(
            AllEffects.Restoration.CureDisease,
            0.5,
            5,
            0
        );
    }
}