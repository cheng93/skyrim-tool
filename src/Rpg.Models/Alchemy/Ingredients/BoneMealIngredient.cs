using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BoneMealIngredient : Ingredient
    {
        public BoneMealIngredient()
        {
            Name = "Bone Meal";
            PrimaryEffect = AllAlchemyEffects.DamageStamina;
            SecondaryEffect = AllAlchemyEffects.ResistFire;
            TertiaryEffect = AllAlchemyEffects.FortifyConjuration;
            QuaternaryEffect = AllAlchemyEffects.RavageStamina;
        }

        public override string Name { get; }

        public override string Id { get; } = "00034cdd";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly BoneMealIngredient BoneMeal = new BoneMealIngredient();
    }
}