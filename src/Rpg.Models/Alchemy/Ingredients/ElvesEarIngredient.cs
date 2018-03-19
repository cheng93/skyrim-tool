using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class ElvesEarIngredient : Ingredient
    {
        public ElvesEarIngredient()
        {
            Name = "Elves Ear";
            PrimaryEffect = AllAlchemyEffects.RestoreMagicka;
            SecondaryEffect = AllAlchemyEffects.FortifyArchery;
            TertiaryEffect = AllAlchemyEffects.WeaknessToFrost;
            QuaternaryEffect = AllAlchemyEffects.ResistFire;
        }

        public override string Name { get; }

        public override string Id { get; } = "00034d31";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly ElvesEarIngredient ElvesEar = new ElvesEarIngredient();
    }
}