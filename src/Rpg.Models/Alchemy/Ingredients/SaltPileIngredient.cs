using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SaltPileIngredient : Ingredient
    {
        public SaltPileIngredient()
        {
            Name = "Salt Pile";
            PrimaryEffect = AllAlchemyEffects.WeaknessToMagic;
            SecondaryEffect = AllAlchemyEffects.FortifyRestoration;
            TertiaryEffect = AllAlchemyEffects.Slow;
            QuaternaryEffect = AllAlchemyEffects.RegenerateMagicka;
        }

        public override string Name { get; }

        public override string Id { get; } = "00034cdf";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SaltPileIngredient SaltPile = new SaltPileIngredient();
    }
}