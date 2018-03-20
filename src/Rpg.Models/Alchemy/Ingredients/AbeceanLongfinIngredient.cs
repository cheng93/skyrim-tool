using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class AbeceanLongfinIngredient : Ingredient
    {
        public AbeceanLongfinIngredient()
        {
            Name = "Abecean Longfin";
            PrimaryEffect = AllAlchemyEffects.WeaknessToFrost;
            SecondaryEffect = AllAlchemyEffects.FortifySneak;
            TertiaryEffect = AllAlchemyEffects.WeaknessToPoison;
            QuaternaryEffect = AllAlchemyEffects.FortifyRestoration;
        }

        public override string Name { get; }

        public override string Id { get; } = "00106e1b";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly AbeceanLongfinIngredient AbeceanLongfin = new AbeceanLongfinIngredient();
    }
}