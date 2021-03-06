using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class TaprootIngredient : Ingredient
    {
        public TaprootIngredient()
        {
            Name = "Taproot";
            PrimaryEffect = AllAlchemyEffects.WeaknessToMagic;
            SecondaryEffect = AllAlchemyEffects.FortifyIllusion;
            TertiaryEffect = AllAlchemyEffects.RegenerateMagicka;
            QuaternaryEffect = AllAlchemyEffects.RestoreMagicka;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad71";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly TaprootIngredient Taproot = new TaprootIngredient();
    }
}