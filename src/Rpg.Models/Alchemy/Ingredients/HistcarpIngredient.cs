using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HistcarpIngredient : Ingredient
    {
        public HistcarpIngredient()
        {
            Name = "Histcarp";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyMagicka;
            TertiaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
            QuaternaryEffect = AllAlchemyEffects.Waterbreathing;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HistcarpIngredient Histcarp = new HistcarpIngredient();
    }
}