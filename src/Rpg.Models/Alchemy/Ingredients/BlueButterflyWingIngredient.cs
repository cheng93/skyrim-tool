using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BlueButterflyWingIngredient : Ingredient
    {
        public BlueButterflyWingIngredient()
        {
            Name = "Blue Butterfly Wing";
            PrimaryEffect = AllAlchemyEffects.DamageStamina;
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
        public static readonly BlueButterflyWingIngredient BlueButterflyWing = new BlueButterflyWingIngredient();
    }
}