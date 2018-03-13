using System.ComponentModel;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Common.Enums;
using Rpg.Models.Extensions;

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
}