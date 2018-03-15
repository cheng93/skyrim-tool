using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class ButterflyWingIngredient : Ingredient
    {
        public ButterflyWingIngredient()
        {
            Name = "Butterfly Wing";
            PrimaryEffect = AllAlchemyEffects.RestoreHealth;
            SecondaryEffect = AllAlchemyEffects.FortifyBarter;
            TertiaryEffect = AllAlchemyEffects.LingeringDamageStamina;
            QuaternaryEffect = AllAlchemyEffects.DamageMagicka;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly ButterflyWingIngredient ButterflyWing = new ButterflyWingIngredient();
    }
}