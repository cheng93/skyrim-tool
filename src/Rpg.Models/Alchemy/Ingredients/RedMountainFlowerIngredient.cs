using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class RedMountainFlowerIngredient : Ingredient
    {
        public RedMountainFlowerIngredient()
        {
            Name = "Red Mountain Flower";
            PrimaryEffect = AllAlchemyEffects.RestoreMagicka;
            SecondaryEffect = AllAlchemyEffects.RavageMagicka;
            TertiaryEffect = AllAlchemyEffects.FortifyMagicka;
            QuaternaryEffect = AllAlchemyEffects.DamageHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly RedMountainFlowerIngredient RedMountainFlower = new RedMountainFlowerIngredient();
    }
}