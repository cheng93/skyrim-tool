using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects.Destruction;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class RavageAttributeAlchemyEffect : AlchemyEffect<RavageAttributeEffect>
    {
        public RavageAttributeAlchemyEffect(
            RavageAttributeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = false;
            Name = $"Ravage {Effect.Attribute.ToPresentableString()}";
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
                    return $"Causes {Magnitude} points of concentrated poison damage.";
                case Attribute.Magicka:
                case Attribute.Stamina:
                    return $"Concentrated poison damages {attribute.ToPresentableString()} by {Magnitude} points.";
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}