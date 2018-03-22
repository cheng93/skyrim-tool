using System.Collections.Generic;
using Rpg.Models.Common.Enums;
using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class RegenerateAttributeAlchemyEffect : AlchemyEffect<RegenerateAttributeEffect>
    {
        public RegenerateAttributeAlchemyEffect(
            RegenerateAttributeEffect effect,
            decimal cost,
            decimal duration,
            decimal magnitude)
            : base(effect, cost, duration, magnitude)
        {
        }

        public override bool IsPositiveEffect { get; } = true;

        public override string Name => $"Regenerate {Effect.Attribute.ToPresentableString()}";

        public override string Description => $"{Effect.Attribute.ToPresentableString()} regenerates {Magnitude}% faster for {Duration} seconds.";

        public override string Id => idMap[Effect.Attribute];

        private static readonly Dictionary<Attribute, string> idMap = new Dictionary<Attribute, string>()
        {
            { Attribute.Health, "0003EB06"},
            { Attribute.Magicka, "0003EB07"},
            { Attribute.Stamina, "0003EB08"}
        };
    }

    public static partial class AllAlchemyEffects
    {
        internal static RegenerateAttributeAlchemyEffect Create(this RegenerateAttributeAlchemyEffect e, decimal cost, decimal duration, decimal magnitude)
        {
            return new RegenerateAttributeAlchemyEffect(e.Effect, cost, duration, magnitude);
        }

        public static readonly RegenerateAttributeAlchemyEffect RegenerateHealth = new RegenerateAttributeAlchemyEffect(
            AllEffects.Restoration.RegenerateHealth,
            cost: 0.1M,
            duration: 300,
            magnitude: 5
        );

        public static readonly RegenerateAttributeAlchemyEffect RegenerateMagicka = new RegenerateAttributeAlchemyEffect(
            AllEffects.Restoration.RegenerateMagicka,
            cost: 0.1M,
            duration: 300,
            magnitude: 5
        );

        public static readonly RegenerateAttributeAlchemyEffect RegenerateStamina = new RegenerateAttributeAlchemyEffect(
            AllEffects.Restoration.RegenerateStamina,
            cost: 0.1M,
            duration: 300,
            magnitude: 5
        );
    }
}