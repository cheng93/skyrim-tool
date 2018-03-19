using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class WhiteCapIngredient : Ingredient
    {
        public WhiteCapIngredient()
        {
            Name = "White Cap";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFrost;
            SecondaryEffect = AllAlchemyEffects.FortifyHeavyArmor;
            TertiaryEffect = AllAlchemyEffects.RestoreMagicka;
            QuaternaryEffect = AllAlchemyEffects.RavageMagicka;
        }

        public override string Name { get; }

        public override string Id { get; } = "0004da22";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly WhiteCapIngredient WhiteCap = new WhiteCapIngredient();
    }
}