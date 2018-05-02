using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class RockWarblerEggIngredient : Ingredient
    {
        public RockWarblerEggIngredient()
        {
            Name = "Rock Warbler Egg";
            PrimaryEffect = AllAlchemyEffects.RestoreHealth;
            SecondaryEffect = AllAlchemyEffects.FortifyOneHanded;
            TertiaryEffect = AllAlchemyEffects.DamageStamina;
            QuaternaryEffect = AllAlchemyEffects.WeaknessToMagic;
        }

        public override string Name { get; }

        public override string Id { get; } = "0007e8c8";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly RockWarblerEggIngredient RockWarblerEgg = new RockWarblerEggIngredient();
    }
}