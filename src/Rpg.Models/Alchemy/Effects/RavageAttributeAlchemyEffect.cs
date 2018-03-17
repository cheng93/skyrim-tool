using System.Collections.Generic;
using System.ComponentModel;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects;
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
            Id = idMap[Effect.Attribute];
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }

        public override string Id { get; } = "";

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

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Health, "00073F26"},
            { Attribute.Magicka, "00073F27"},
            { Attribute.Stamina, "00073F23"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly RavageAttributeAlchemyEffect RavageHealth = new RavageAttributeAlchemyEffect(
            AllEffects.Destruction.RavageHealth,
            cost: 0.4,
            duration: 10,
            magnitude: 2
        );

        public static readonly RavageAttributeAlchemyEffect RavageMagicka = new RavageAttributeAlchemyEffect(
            AllEffects.Destruction.RavageMagicka,
            cost: 1,
            duration: 10,
            magnitude: 2
        );

        public static readonly RavageAttributeAlchemyEffect RavageStamina = new RavageAttributeAlchemyEffect(
            AllEffects.Destruction.RavageStamina,
            cost: 1.6,
            duration: 10,
            magnitude: 2
        );
    }
}