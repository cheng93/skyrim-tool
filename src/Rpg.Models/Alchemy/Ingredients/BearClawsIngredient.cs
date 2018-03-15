using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BearClawsIngredient : Ingredient
    {
        public BearClawsIngredient()
        {
            Name = "Bear Claws";
            PrimaryEffect = AllAlchemyEffects.DamageStamina.ScaleMagnitude(0.8);
            SecondaryEffect = AllAlchemyEffects.FortifyConjuration;
            TertiaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
            QuaternaryEffect = AllAlchemyEffects.FortifyEnchanting;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly BearClawsIngredient BearClaws = new BearClawsIngredient();
    }
}