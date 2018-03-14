using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class GiantLichenIngredient : Ingredient
    {
        public GiantLichenIngredient()
        {
            Name = "Giant Lichen";
            PrimaryEffect = AllAlchemyEffects.WeaknessToShock;
            SecondaryEffect = AllAlchemyEffects.RavageHealth;
            TertiaryEffect = AllAlchemyEffects.WeaknessToPoison;
            QuaternaryEffect = AllAlchemyEffects.RestoreMagicka;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly GiantLichenIngredient GiantLichen = new GiantLichenIngredient();
    }
}