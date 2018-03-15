using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class whiteCapIngredient : Ingredient
    {
        public whiteCapIngredient()
        {
            Name = "white Cap";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFrost;
            SecondaryEffect = AllAlchemyEffects.FortifyHeavyArmor;
            TertiaryEffect = AllAlchemyEffects.RestoreMagicka;
            QuaternaryEffect = AllAlchemyEffects.RavageMagicka;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly whiteCapIngredient whiteCap = new whiteCapIngredient();
    }
}