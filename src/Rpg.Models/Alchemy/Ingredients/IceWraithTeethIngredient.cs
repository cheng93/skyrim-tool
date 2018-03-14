using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class IceWraithTeethIngredient : Ingredient
    {
        public IceWraithTeethIngredient()
        {
            Name = "Ice Wraith Teeth";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFrost;
            SecondaryEffect = AllAlchemyEffects.FortifyHeavyArmor;
            TertiaryEffect = AllAlchemyEffects.Invisibility;
            QuaternaryEffect = AllAlchemyEffects.WeaknessToFire;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly IceWraithTeethIngredient IceWraithTeeth = new IceWraithTeethIngredient();
    }
}