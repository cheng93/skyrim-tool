using System.Collections.Generic;
using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class LingeringDamageAttributeAlchemyEffect : AlchemyEffect<LingeringDamageAttributeEffect>
    {
        public LingeringDamageAttributeAlchemyEffect(
            LingeringDamageAttributeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name => $"Lingering Damage {Effect.Attribute.ToPresentableString()}";

        public override string Id => idMap[Effect.Attribute];

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Health, "0010AA4A"},
            { Attribute.Magicka, "0010DE5F"},
            { Attribute.Stamina, "0010DE5E"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly LingeringDamageAttributeAlchemyEffect LingeringDamageHealth = new LingeringDamageAttributeAlchemyEffect(
            AllEffects.Destruction.LingeringDamageHealth,
            cost: 12,
            duration: 10,
            magnitude: 1
        );

        public static readonly LingeringDamageAttributeAlchemyEffect LingeringDamageMagicka = new LingeringDamageAttributeAlchemyEffect(
            AllEffects.Destruction.LingeringDamageMagicka,
            cost: 10,
            duration: 10,
            magnitude: 1
        );

        public static readonly LingeringDamageAttributeAlchemyEffect LingeringDamageStamina = new LingeringDamageAttributeAlchemyEffect(
            AllEffects.Destruction.LingeringDamageStamina,
            cost: 1.8,
            duration: 10,
            magnitude: 1
        );
    }
}