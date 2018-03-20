using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class TrollFatIngredient : Ingredient
    {
        public TrollFatIngredient()
        {
            Name = "Troll Fat";
            PrimaryEffect = AllAlchemyEffects.ResistPoison;
            SecondaryEffect = AllAlchemyEffects.FortifyTwoHanded;
            TertiaryEffect = AllAlchemyEffects.Frenzy;
            QuaternaryEffect = AllAlchemyEffects.DamageHealth;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad72";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly TrollFatIngredient TrollFat = new TrollFatIngredient();
    }
}