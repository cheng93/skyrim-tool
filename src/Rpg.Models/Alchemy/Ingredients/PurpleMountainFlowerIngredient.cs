using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class PurpleMountainFlowerIngredient : Ingredient
    {
        public PurpleMountainFlowerIngredient()
        {
            Name = "Purple Mountain Flower";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifySneak;
            TertiaryEffect = AllAlchemyEffects.LingeringDamageMagicka;
            QuaternaryEffect = AllAlchemyEffects.ResistFrost;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly PurpleMountainFlowerIngredient PurpleMountainFlower = new PurpleMountainFlowerIngredient();
    }
}