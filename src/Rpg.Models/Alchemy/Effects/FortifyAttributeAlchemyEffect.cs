using System.Collections.Generic;
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
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name => $"Fortify {Effect.Attribute.ToPresentableString()}";

        public override string Description => $"{Effect.Attribute.ToPresentableString()} is increased by {Magnitude} points for {Duration} seconds.";

        public override string Id => idMap[Effect.Attribute];

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Health, "0003EAF3"},
            { Attribute.Magicka, "0003EAF8"},
            { Attribute.Stamina, "0003EAF9"}
        };
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