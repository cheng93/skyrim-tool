using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class WheatIngredient : Ingredient
    {
        public WheatIngredient()
        {
            Name = "Wheat";
            PrimaryEffect = AllAlchemyEffects.RestoreHealth;
            SecondaryEffect = AllAlchemyEffects.FortifyHealth;
            TertiaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
            QuaternaryEffect = AllAlchemyEffects.LingeringDamageMagicka;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly WheatIngredient Wheat = new WheatIngredient();
    }
}