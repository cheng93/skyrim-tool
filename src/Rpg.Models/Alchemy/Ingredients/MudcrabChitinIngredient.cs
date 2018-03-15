using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class MudcrabChitinIngredient : Ingredient
    {
        public MudcrabChitinIngredient()
        {
            Name = "Mudcrab Chitin";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.CureDisease;
            TertiaryEffect = AllAlchemyEffects.ResistPoison;
            QuaternaryEffect = AllAlchemyEffects.ResistFire;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly MudcrabChitinIngredient MudcrabChitin = new MudcrabChitinIngredient();
    }
}