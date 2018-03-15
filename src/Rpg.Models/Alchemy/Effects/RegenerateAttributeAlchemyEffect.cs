using Rpg.Models.Effects;
using Rpg.Models.Effects.Restoration;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Effects
{
    public class RegenerateAttributeAlchemyEffect : AlchemyEffect<RegenerateAttributeEffect>
    {
        public RegenerateAttributeAlchemyEffect(
            RegenerateAttributeEffect effect,
            double cost,
            double duration,
            double magnitude)
            : base(effect, cost, duration, magnitude)
        {
            IsPositiveEffect = true;
            Name = $"Regenerate {Effect.Attribute.ToPresentableString()}";
            Description = $"{Effect.Attribute.ToPresentableString()} regenerates {Magnitude}% faster for {Duration} seconds.";
        }

        public override bool IsPositiveEffect { get; }

        public override string Name { get; }

        public override string Description { get; }
    }

    public static partial class AllAlchemyEffects
    {
        public static readonly RegenerateAttributeAlchemyEffect RegenerateHealth = new RegenerateAttributeAlchemyEffect(
            AllEffects.Restoration.RegenerateHealth,
            cost: 0.1,
            duration: 300,
            magnitude: 5
        );

        public static readonly RegenerateAttributeAlchemyEffect RegenerateMagicka = new RegenerateAttributeAlchemyEffect(
            AllEffects.Restoration.RegenerateMagicka,
            cost: 0.1,
            duration: 300,
            magnitude: 5
        );

        public static readonly RegenerateAttributeAlchemyEffect RegenerateStamina = new RegenerateAttributeAlchemyEffect(
            AllEffects.Restoration.RegenerateStamina,
            cost: 0.1,
            duration: 300,
            magnitude: 5
        );
    }
}