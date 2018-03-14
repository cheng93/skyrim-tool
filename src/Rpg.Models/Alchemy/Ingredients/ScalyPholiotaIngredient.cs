using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class ScalyPholiotaIngredient : Ingredient
    {
        public ScalyPholiotaIngredient()
        {
            Name = "Scaly Pholiota";
            PrimaryEffect = AllAlchemyEffects.WeaknessToMagic;
            SecondaryEffect = AllAlchemyEffects.FortifyIllusion;
            TertiaryEffect = AllAlchemyEffects.RegenerateStamina;
            QuaternaryEffect = AllAlchemyEffects.FortifyCarryWeight;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly ScalyPholiotaIngredient ScalyPholiota = new ScalyPholiotaIngredient();
    }
}