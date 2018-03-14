using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BlueDartwingIngredient : Ingredient
    {
        public BlueDartwingIngredient()
        {
            Name = "Blue Dartwing";
            PrimaryEffect = AllAlchemyEffects.ResistShock;
            SecondaryEffect = AllAlchemyEffects.FortifyPickpocket;
            TertiaryEffect = AllAlchemyEffects.RestoreHealth;
            QuaternaryEffect = AllAlchemyEffects.Fear;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly BlueDartwingIngredient BlueDartwing = new BlueDartwingIngredient();
    }
}