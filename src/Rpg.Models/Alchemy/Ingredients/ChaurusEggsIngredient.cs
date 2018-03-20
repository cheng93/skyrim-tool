using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class ChaurusEggsIngredient : Ingredient
    {
        public ChaurusEggsIngredient()
        {
            Name = "Chaurus Eggs";
            PrimaryEffect = AllAlchemyEffects.WeaknessToPoison;
            SecondaryEffect = AllAlchemyEffects.FortifyStamina;
            TertiaryEffect = AllAlchemyEffects.DamageMagicka;
            QuaternaryEffect = AllAlchemyEffects.Invisibility;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad56";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly ChaurusEggsIngredient ChaurusEggs = new ChaurusEggsIngredient();
    }
}