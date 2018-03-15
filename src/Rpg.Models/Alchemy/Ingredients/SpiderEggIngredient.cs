using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SpiderEggIngredient : Ingredient
    {
        public SpiderEggIngredient()
        {
            Name = "Spider Egg";
            PrimaryEffect = AllAlchemyEffects.DamageStamina;
            SecondaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
            TertiaryEffect = AllAlchemyEffects.FortifyLockpicking;
            QuaternaryEffect = AllAlchemyEffects.FortifyArchery;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SpiderEggIngredient SpiderEgg = new SpiderEggIngredient();
    }
}