using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class GlowingMushroomIngredient : Ingredient
    {
        public GlowingMushroomIngredient()
        {
            Name = "Glowing Mushroom";
            PrimaryEffect = AllAlchemyEffects.ResistShock;
            SecondaryEffect = AllAlchemyEffects.FortifyDestruction;
            TertiaryEffect = AllAlchemyEffects.FortifySmithing;
            QuaternaryEffect = AllAlchemyEffects.FortifyHealth;
        }

        public override string Name { get; }

        public override string Id { get; } = "0007ee01";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly GlowingMushroomIngredient GlowingMushroom = new GlowingMushroomIngredient();
    }
}