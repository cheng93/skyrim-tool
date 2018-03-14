using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BlueMountainFlowerIngredient : Ingredient
    {
        public BlueMountainFlowerIngredient()
        {
            Name = "Blue Mountain Flower";
            PrimaryEffect = AllAlchemyEffects.RestoreHealth;
            SecondaryEffect = AllAlchemyEffects.FortifyConjuration;
            TertiaryEffect = AllAlchemyEffects.FortifyHealth;
            QuaternaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly BlueMountainFlowerIngredient BlueMountainFlower = new BlueMountainFlowerIngredient();
    }
}