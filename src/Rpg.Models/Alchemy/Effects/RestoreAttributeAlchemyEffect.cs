using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects.Restoration;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class RestoreAttributeAlchemyEffect : AlchemyEffect<RestoreAttributeEffect>
    {
        public RestoreAttributeAlchemyEffect(
            RestoreAttributeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = $"Restore {effect.Attribute.ToPresentableString()}";
            Description = GetDescription(effect.Attribute);
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        private string  GetDescription(Attribute attribute)
        {
            switch(attribute)
            {
                case Attribute.Health:
                case Attribute.Magicka:
                    return $"Restore {Magnitude} points of {attribute.ToPresentableString()}.";
                case Attribute.Stamina:
                    return $"Restore {Magnitude} Stamina.";
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}