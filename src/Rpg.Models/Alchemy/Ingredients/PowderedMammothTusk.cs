using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class PowderedMammothTuskIngredient : Ingredient
    {
        public PowderedMammothTuskIngredient()
        {
            Name = "Powdered Mammoth Tusk";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifySneak;
            TertiaryEffect = AllAlchemyEffects.WeaknessToFire;
            QuaternaryEffect = AllAlchemyEffects.Fear;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly PowderedMammothTuskIngredient PowderedMammothTusk = new PowderedMammothTuskIngredient();
    }
}