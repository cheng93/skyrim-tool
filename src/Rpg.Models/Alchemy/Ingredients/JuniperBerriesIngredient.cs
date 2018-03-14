using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class JuniperBerriesIngredient : Ingredient
    {
        public JuniperBerriesIngredient()
        {
            Name = "Juniper Berries";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFire;
            SecondaryEffect = AllAlchemyEffects.FortifyArchery;
            TertiaryEffect = AllAlchemyEffects.RegenerateHealth;
            QuaternaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly JuniperBerriesIngredient JuniperBerries = new JuniperBerriesIngredient();
    }
}