using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SilversidePerchIngredient : Ingredient
    {
        public SilversidePerchIngredient()
        {
            Name = "Silverside Perch";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
            TertiaryEffect = AllAlchemyEffects.RavageHealth;
            QuaternaryEffect = AllAlchemyEffects.ResistFrost;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SilversidePerchIngredient SilversidePerch = new SilversidePerchIngredient();
    }
}