using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class JazbayGrapesIngredient : Ingredient
    {
        public JazbayGrapesIngredient()
        {
            Name = "Jazbay Grapes";
            PrimaryEffect = AllAlchemyEffects.WeaknessToMagic;
            SecondaryEffect = AllAlchemyEffects.FortifyMagicka;
            TertiaryEffect = AllAlchemyEffects.RegenerateMagicka;
            QuaternaryEffect = AllAlchemyEffects.RavageHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly JazbayGrapesIngredient JazbayGrapes = new JazbayGrapesIngredient();
    }
}