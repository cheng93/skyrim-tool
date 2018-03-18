using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HawkFeathersIngredient : Ingredient
    {
        public HawkFeathersIngredient()
        {
            Name = "Hawk Feathers";
            PrimaryEffect = AllAlchemyEffects.CureDisease.ScaleCost(0.36);
            SecondaryEffect = AllAlchemyEffects.FortifyLightArmor;
            TertiaryEffect = AllAlchemyEffects.FortifyOneHanded;
            QuaternaryEffect = AllAlchemyEffects.FortifySneak;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HawkFeathersIngredient HawkFeathers = new HawkFeathersIngredient();
    }
}