using System.ComponentModel;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Common.Enums;
using Rpg.Models.Extensions;
using Rpg.Models.Effects;
using System.Collections.Generic;

namespace Rpg.Models.Alchemy.Effects
{
    public class DamageAttributeRegenerationAlchemyEffect : AlchemyEffect<DamageAttributeRegenerationEffect>
    {
        public DamageAttributeRegenerationAlchemyEffect()
        {
        }

        public DamageAttributeRegenerationAlchemyEffect(
            DamageAttributeRegenerationEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            if (effect.Attribute == Attribute.Health)
            {
                throw new InvalidEnumArgumentException();
            }
    
            IsPositiveEffect = false;
            Name = $"Damage {Effect.Attribute.ToPresentableString()} Regen";
            Description = GetDescription(Effect.Attribute);
            Id = idMap[Effect.Attribute];
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        public override string Id { get; }

        private string GetDescription(Attribute attribute)
        {
            switch(attribute)
            {
                case Attribute.Magicka:
                case Attribute.Stamina:
                    return $"Decrease the target's {attribute.ToPresentableString()} regeneration by {Magnitude}% for {Duration} seconds.";
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Magicka, "00073F2B"},
            { Attribute.Stamina, "00073F2C"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly DamageAttributeRegenerationAlchemyEffect DamageMagickaRegeneration = new DamageAttributeRegenerationAlchemyEffect(
            AllEffects.Destruction.DamageMagickaRegeneration,
            cost: 0.5,
            duration: 5,
            magnitude: 100
        );

        public static readonly DamageAttributeRegenerationAlchemyEffect DamageStaminaRegeneration = new DamageAttributeRegenerationAlchemyEffect(
            AllEffects.Destruction.DamageStaminaRegeneration,
            cost: 0.3,
            duration: 5,
            magnitude: 100
        );
    }
}