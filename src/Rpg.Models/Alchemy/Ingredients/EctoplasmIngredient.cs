using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class EctoplasmIngredient : Ingredient
    {
        public EctoplasmIngredient()
        {
            Name = "Ectoplasm";
            PrimaryEffect = AllAlchemyEffects.RestoreMagicka;
            SecondaryEffect = AllAlchemyEffects.FortifyDestruction.ScaleMagnitude(0.8);
            TertiaryEffect = AllAlchemyEffects.FortifyMagicka;
            QuaternaryEffect = AllAlchemyEffects.DamageHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly EctoplasmIngredient Ectoplasm = new EctoplasmIngredient();
    }
}