using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SnowberriesIngredient : Ingredient
    {
        public SnowberriesIngredient()
        {
            Name = "Snowberries";
            PrimaryEffect = AllAlchemyEffects.ResistFire;
            SecondaryEffect = AllAlchemyEffects.FortifyEnchanting;
            TertiaryEffect = AllAlchemyEffects.ResistFrost;
            QuaternaryEffect = AllAlchemyEffects.ResistShock;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SnowberriesIngredient Snowberries = new SnowberriesIngredient();
    }
}