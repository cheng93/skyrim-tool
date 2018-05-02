using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BleedingCrownIngredient : Ingredient
    {
        public BleedingCrownIngredient()
        {
            Name = "Bleeding Crown";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFire;
            SecondaryEffect = AllAlchemyEffects.FortifyBlock;
            TertiaryEffect = AllAlchemyEffects.WeaknessToPoison;
            QuaternaryEffect = AllAlchemyEffects.ResistMagic;
        }

        public override string Name { get; }

        public override string Id { get; } = "0004da20";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly BleedingCrownIngredient BleedingCrown = new BleedingCrownIngredient();
    }
}