using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class GarlicIngredient : Ingredient
    {
        public GarlicIngredient()
        {
            Name = "Garlic";
            PrimaryEffect = AllAlchemyEffects.ResistPoison;
            SecondaryEffect = AllAlchemyEffects.FortifyStamina;
            TertiaryEffect = AllAlchemyEffects.RegenerateMagicka;
            QuaternaryEffect = AllAlchemyEffects.RegenerateHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly GarlicIngredient Garlic = new GarlicIngredient();
    }
}