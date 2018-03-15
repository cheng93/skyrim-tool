using System.ComponentModel;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Common.Enums;
using Rpg.Models.Extensions;
using Rpg.Models.Effects;

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
            IsPositiveEffect = false;
            Name = $"Damage {Effect.Attribute.ToPresentableString()}";
            Description = GetDescription(Effect.Attribute);
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

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