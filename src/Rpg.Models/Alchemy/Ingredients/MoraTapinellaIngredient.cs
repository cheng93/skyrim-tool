using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class MoraTapinellaIngredient : Ingredient
    {
        public MoraTapinellaIngredient()
        {
            Name = "Mora Tapinella";
            PrimaryEffect = AllAlchemyEffects.RestoreMagicka;
            SecondaryEffect = AllAlchemyEffects.LingeringDamageHealth;
            TertiaryEffect = AllAlchemyEffects.RegenerateStamina;
            QuaternaryEffect = AllAlchemyEffects.FortifyIllusion;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly MoraTapinellaIngredient MoraTapinella = new MoraTapinellaIngredient();
    }
}