using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class MoonSugarIngredient : Ingredient
    {
        public MoonSugarIngredient()
        {
            Name = "Moon Sugar";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFire;
            SecondaryEffect = AllAlchemyEffects.ResistFrost;
            TertiaryEffect = AllAlchemyEffects.RestoreMagicka;
            QuaternaryEffect = AllAlchemyEffects.RegenerateMagicka;
        }

        public override string Name { get; }

        public override string Id { get; } = "000D8E3F";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly MoonSugarIngredient MoonSugar = new MoonSugarIngredient();
    }
}