using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class FireSaltsIngredient : Ingredient
    {
        public FireSaltsIngredient()
        {
            Name = "Fire Salts";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFrost;
            SecondaryEffect = AllAlchemyEffects.ResistFire;
            TertiaryEffect = AllAlchemyEffects.RestoreMagicka;
            QuaternaryEffect = AllAlchemyEffects.RegenerateMagicka;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad5e";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly FireSaltsIngredient FireSalts = new FireSaltsIngredient();
    }
}