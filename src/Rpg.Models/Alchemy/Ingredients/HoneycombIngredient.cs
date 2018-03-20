using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HoneycombIngredient : Ingredient
    {
        public HoneycombIngredient()
        {
            Name = "Honeycomb";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyBlock.ScaleMagnitude(0.5);
            TertiaryEffect = AllAlchemyEffects.FortifyLightArmor;
            QuaternaryEffect = AllAlchemyEffects.RavageStamina;
        }

        public override string Name { get; }

        public override string Id { get; } = "000b08c5";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HoneycombIngredient Honeycomb = new HoneycombIngredient();
    }
}