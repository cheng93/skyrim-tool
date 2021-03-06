using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BearClawsIngredient : Ingredient
    {
        public BearClawsIngredient()
        {
            Name = "Bear Claws";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina.ScaleMagnitude(0.8M);
            SecondaryEffect = AllAlchemyEffects.FortifyHealth;
            TertiaryEffect = AllAlchemyEffects.FortifyOneHanded;
            QuaternaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
        }

        public override string Name { get; }

        public override string Id { get; } = "0006bc02";

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