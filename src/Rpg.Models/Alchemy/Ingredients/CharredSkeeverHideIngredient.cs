using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class CharredSkeeverHideIngredient : Ingredient
    {
        public CharredSkeeverHideIngredient()
        {
            Name = "Charred Skeever Hide";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.CureDisease.ScaleCost(0.36);
            TertiaryEffect = AllAlchemyEffects.ResistPoison;
            QuaternaryEffect = AllAlchemyEffects.RestoreHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly CharredSkeeverHideIngredient CharredSkeeverHide = new CharredSkeeverHideIngredient();
    }
}