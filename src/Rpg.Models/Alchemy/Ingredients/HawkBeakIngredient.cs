using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HawkBeakIngredient : Ingredient
    {
        public HawkBeakIngredient()
        {
            Name = "Hawk Beak";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.ResistFrost;
            TertiaryEffect = AllAlchemyEffects.FortifyCarryWeight;
            QuaternaryEffect = AllAlchemyEffects.ResistShock;
        }

        public override string Name { get; }

        public override string Id { get; } = "000e7ebc";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HawkBeakIngredient HawkBeak = new HawkBeakIngredient();
    }
}