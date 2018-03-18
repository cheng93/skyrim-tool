using System.Collections.Generic;
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
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name => $"Restore {Effect.Attribute.ToPresentableString()}";

        public override string Description => GetDescription(Effect.Attribute);

        public override string Id => idMap[Effect.Attribute];

        private string GetDescription(Attribute attribute)
        {
            switch (attribute)
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

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Health, "0003EB15"},
            { Attribute.Magicka, "0003EB17"},
            { Attribute.Stamina, "0003EB16"}
        };
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