using System.ComponentModel;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Common.Enums;
using Rpg.Models.Extensions;
using Rpg.Models.Effects;
using System.Collections.Generic;

namespace Rpg.Models.Alchemy.Effects
{
    public class DamageAttributeAlchemyEffect : AlchemyEffect<DamageAttributeEffect>
    {
        public DamageAttributeAlchemyEffect(
            DamageAttributeEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude) 
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name => $"Damage {Effect.Attribute.ToPresentableString()}";

        public override string Description => GetDescription(Effect.Attribute);

        public override string Id => idMap[Effect.Attribute];

        private string GetDescription(Attribute attribute)
        {
            switch(attribute)
            {
                case Attribute.Health:
                    return $"Causes {Magnitude} points of poison damage.";
                case Attribute.Magicka:
                case Attribute.Stamina:
                    return $"Drains the target's {attribute.ToPresentableString()} by {Magnitude} points.";
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Health, "0003EB42"},
            { Attribute.Magicka, "0003A2B6"},
            { Attribute.Stamina, "0003A2C6"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        internal static DamageAttributeAlchemyEffect Create(this DamageAttributeAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new DamageAttributeAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly DamageAttributeAlchemyEffect DamageHealth = new DamageAttributeAlchemyEffect(
            AllEffects.Destruction.DamageHealth,
            cost: 3,
            duration: 1,
            magnitude: 2
        );

        public static readonly DamageAttributeAlchemyEffect DamageMagicka = new DamageAttributeAlchemyEffect(
            AllEffects.Destruction.DamageMagicka,
            cost: 2.2M,
            duration: 0,
            magnitude: 3
        );

        public static readonly DamageAttributeAlchemyEffect DamageStamina = new DamageAttributeAlchemyEffect(
            AllEffects.Destruction.DamageStamina,
            cost: 1.8M,
            duration: 0,
            magnitude: 3
        );
    }
}