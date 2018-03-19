using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class PineThrushEggIngredient : Ingredient
    {
        public PineThrushEggIngredient()
        {
            Name = "Pine Thrush Egg";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyLockpicking;
            TertiaryEffect = AllAlchemyEffects.WeaknessToPoison;
            QuaternaryEffect = AllAlchemyEffects.ResistShock;
        }

        public override string Name { get; }

        public override string Id { get; } = "00023d6f";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly PineThrushEggIngredient PineThrushEgg = new PineThrushEggIngredient();
    }
}