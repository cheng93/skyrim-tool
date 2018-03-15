using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SabreCatToothIngredient : Ingredient
    {
        public SabreCatToothIngredient()
        {
            Name = "Sabre Cat Tooth";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyHeavyArmor;
            TertiaryEffect = AllAlchemyEffects.FortifySmithing;
            QuaternaryEffect = AllAlchemyEffects.WeaknessToPoison;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SabreCatToothIngredient SabreCatTooth = new SabreCatToothIngredient();
    }
}