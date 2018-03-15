using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class FortifyAttributeAlchemyEffect : AlchemyEffect<FortifyAttributeEffect>
    {
        public FortifyAttributeAlchemyEffect(
            FortifyAttributeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = $"Fortify {Effect.Attribute.ToPresentableString()}";
            Description = $"{Effect.Attribute.ToPresentableString()} is increased by {Magnitude} points for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly FortifyAttributeAlchemyEffect FortifyHealth = new FortifyAttributeAlchemyEffect(
            AllEffects.Restoration.FortifyHealth,
            cost: 0.35,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifyAttributeAlchemyEffect FortifyMagicka = new FortifyAttributeAlchemyEffect(
            AllEffects.Restoration.FortifyMagicka,
            cost: 0.3,
            duration: 60,
            magnitude: 4
        );

        public static readonly FortifyAttributeAlchemyEffect FortifyStamina = new FortifyAttributeAlchemyEffect(
            AllEffects.Restoration.FortifyStamina,
            cost: 0.3,
            duration: 60,
            magnitude: 4
        );
    }
}