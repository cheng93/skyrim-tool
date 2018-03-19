using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SkeeverTailIngredient : Ingredient
    {
        public SkeeverTailIngredient()
        {
            Name = "Skeever Tail";
            PrimaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
            SecondaryEffect = AllAlchemyEffects.RavageHealth;
            TertiaryEffect = AllAlchemyEffects.DamageHealth;
            QuaternaryEffect = AllAlchemyEffects.FortifyLightArmor;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad6f";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SkeeverTailIngredient SkeeverTail = new SkeeverTailIngredient();
    }
}