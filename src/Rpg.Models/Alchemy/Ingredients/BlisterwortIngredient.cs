using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BlisterwortIngredient : Ingredient
    {
        public BlisterwortIngredient()
        {
            Name = "Blisterwort";
            PrimaryEffect = AllAlchemyEffects.DamageStamina;
            SecondaryEffect = AllAlchemyEffects.Frenzy;
            TertiaryEffect = AllAlchemyEffects.RestoreHealth.ScaleMagnitude(0.6M);
            QuaternaryEffect = AllAlchemyEffects.FortifySmithing;
        }

        public override string Name { get; }

        public override string Id { get; } = "0004da25s";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly BlisterwortIngredient Blisterwort = new BlisterwortIngredient();
    }
}