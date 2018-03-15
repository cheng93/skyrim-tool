using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class DeathbellIngredient : Ingredient
    {
        public DeathbellIngredient()
        {
            Name = "Deathbell";
            PrimaryEffect = AllAlchemyEffects.DamageHealth.ScaleMagnitude(1.5);
            SecondaryEffect = AllAlchemyEffects.RavageStamina.ScaleCost(2.1);
            TertiaryEffect = AllAlchemyEffects.Slow;
            QuaternaryEffect = AllAlchemyEffects.WeaknessToPoison;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly DeathbellIngredient Deathbell = new DeathbellIngredient();
    }
}