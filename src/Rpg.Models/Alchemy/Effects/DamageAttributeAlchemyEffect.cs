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
            double cost,
            double duration,
            double magnitude) 
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = false;

        public override string Name => $"Damage {Effect.Attribute.ToPresentableString()}";

        public override string Id => idMap[Effect.Attribute];

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Health, "0003EB42"},
            { Attribute.Magicka, "0003A2B6"},
            { Attribute.Stamina, "0003A2C6"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly DamageAttributeAlchemyEffect DamageHealth = new DamageAttributeAlchemyEffect(
            AllEffects.Destruction.DamageHealth,
            cost: 3,
            duration: 1,
            magnitude: 2
        );

        public static readonly DamageAttributeAlchemyEffect DamageMagicka = new DamageAttributeAlchemyEffect(
            AllEffects.Destruction.DamageMagicka,
            cost: 2.2,
            duration: 0,
            magnitude: 3
        );

        public static readonly DamageAttributeAlchemyEffect DamageStamina = new DamageAttributeAlchemyEffect(
            AllEffects.Destruction.DamageStamina,
            cost: 1.8,
            duration: 0,
            magnitude: 3
        );
    }
}