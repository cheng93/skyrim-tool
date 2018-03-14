using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects;
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

    public static partial class AllAlchemyEffects
    {
        public static readonly RestoreAttributeAlchemyEffect RestoreHealth = new RestoreAttributeAlchemyEffect(
            AllEffects.Restoration.RestoreHealth,
            cost: 0.5,
            duration: 0,
            magnitude: 5
        );

        public static readonly RestoreAttributeAlchemyEffect RestoreMagicka = new RestoreAttributeAlchemyEffect(
            AllEffects.Restoration.RestoreMagicka,
            cost: 0.6,
            duration: 0,
            magnitude: 5
        );

        public static readonly RestoreAttributeAlchemyEffect RestoreStamina = new RestoreAttributeAlchemyEffect(
            AllEffects.Restoration.RestoreStamina,
            cost: 0.6,
            duration: 0,
            magnitude: 5
        );
    }
}