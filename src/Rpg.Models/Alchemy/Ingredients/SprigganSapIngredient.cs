using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SprigganSapIngredient : Ingredient
    {
        public SprigganSapIngredient()
        {
            Name = "Spriggan Sap";
            PrimaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
            SecondaryEffect = AllAlchemyEffects.FortifyEnchanting;
            TertiaryEffect = AllAlchemyEffects.FortifySmithing;
            QuaternaryEffect = AllAlchemyEffects.FortifyAlteration;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SprigganSapIngredient SprigganSap = new SprigganSapIngredient();
    }
}