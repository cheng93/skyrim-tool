using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class LavenderIngredient : Ingredient
    {
        public LavenderIngredient()
        {
            Name = "Lavender";
            PrimaryEffect = AllAlchemyEffects.ResistMagic;
            SecondaryEffect = AllAlchemyEffects.FortifyStamina;
            TertiaryEffect = AllAlchemyEffects.RavageMagicka;
            QuaternaryEffect = AllAlchemyEffects.FortifyConjuration;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly LavenderIngredient Lavender = new LavenderIngredient();
    }
}