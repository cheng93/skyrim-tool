using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class CanisRootIngredient : Ingredient
    {
        public CanisRootIngredient()
        {
            Name = "Canis Root";
            PrimaryEffect = AllAlchemyEffects.DamageStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyOneHanded;
            TertiaryEffect = AllAlchemyEffects.FortifyArchery;
            QuaternaryEffect = AllAlchemyEffects.Paralyze;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly CanisRootIngredient CanisRoot = new CanisRootIngredient();
    }
}