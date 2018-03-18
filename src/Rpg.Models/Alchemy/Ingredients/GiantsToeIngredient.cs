using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class GiantsToeIngredient : Ingredient
    {
        public GiantsToeIngredient()
        {
            Name = "Giant's Toe";
            PrimaryEffect = AllAlchemyEffects.DamageStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyHealth.ScaleMagnitude(5.9);
            TertiaryEffect = AllAlchemyEffects.FortifyCarryWeight;
            QuaternaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly GiantsToeIngredient GiantsToe = new GiantsToeIngredient();
    }
}