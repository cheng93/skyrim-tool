using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class LargeAntlersIngredient : Ingredient
    {
        public LargeAntlersIngredient()
        {
            Name = "Large Antlers";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyStamina;
            TertiaryEffect = AllAlchemyEffects.Slow;
            QuaternaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
        }

        public override string Name { get; }

        public override string Id { get; } = "0006bc0a";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly LargeAntlersIngredient LargeAntlers = new LargeAntlersIngredient();
    }
}