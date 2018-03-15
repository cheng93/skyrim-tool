using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BriarHeartIngredient : Ingredient
    {
        public BriarHeartIngredient()
        {
            Name = "Briar Heart";
            PrimaryEffect = AllAlchemyEffects.RestoreMagicka;
            SecondaryEffect = AllAlchemyEffects.FortifyBlock.ScaleMagnitude(0.5);
            TertiaryEffect = AllAlchemyEffects.Paralyze;
            QuaternaryEffect = AllAlchemyEffects.FortifyMagicka;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly BriarHeartIngredient BriarHeart = new BriarHeartIngredient();
    }
}