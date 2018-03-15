using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class FarengarsFrostSaltIngredient : Ingredient
    {
        public FarengarsFrostSaltIngredient()
        {
            Name = "Farengar's Frost Salt";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFire;
            SecondaryEffect = AllAlchemyEffects.ResistFrost;
            TertiaryEffect = AllAlchemyEffects.RestoreMagicka;
            QuaternaryEffect = AllAlchemyEffects.FortifyConjuration;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly FarengarsFrostSaltIngredient FarengarsFrostSalt = new FarengarsFrostSaltIngredient();
    }
}