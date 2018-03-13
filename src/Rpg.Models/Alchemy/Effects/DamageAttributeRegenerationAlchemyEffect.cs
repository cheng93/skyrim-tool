using System.ComponentModel;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Common.Enums;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class DamageAttributeRegenerationAlchemyEffect : AlchemyEffect<DamageAttributeEffect>
    {
        public DamageAttributeRegenerationAlchemyEffect(
            DamageAttributeEffect effect,
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
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

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
    }
}