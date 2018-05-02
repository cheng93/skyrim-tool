using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class FrostSaltsIngredient : Ingredient
    {
        public FrostSaltsIngredient()
        {
            Name = "Frost Salts";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFire;
            SecondaryEffect = AllAlchemyEffects.ResistFrost;
            TertiaryEffect = AllAlchemyEffects.RestoreMagicka;
            QuaternaryEffect = AllAlchemyEffects.FortifyConjuration;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad5f";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly FrostSaltsIngredient FrostSalts = new FrostSaltsIngredient();
    }
}