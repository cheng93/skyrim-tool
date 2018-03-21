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
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name => $"Lingering Damage {Effect.Attribute.ToPresentableString()}";

        public override string Description => GetDescription(Effect.Attribute);

        public override string Id => idMap[Effect.Attribute];

        private string GetDescription(Attribute attribute)
        {
            switch(attribute)
            {
                case Attribute.Health:
                    return $"Causes {Magnitude} points of poison damage for {Duration} seconds.";
                case Attribute.Magicka:
                case Attribute.Stamina:
                    return $"Drains the target's {attribute.ToPresentableString()} by {Magnitude} points per second for {Duration} seconds.";
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Health, "0010AA4A"},
            { Attribute.Magicka, "0010DE5F"},
            { Attribute.Stamina, "0010DE5E"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        internal static LingeringDamageAttributeAlchemyEffect Create(this LingeringDamageAttributeAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new LingeringDamageAttributeAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

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
            cost: 1.8M,
            duration: 10,
            magnitude: 1
        );
    }
}