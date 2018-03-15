using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class RiverBettyIngredient : Ingredient
    {
        public RiverBettyIngredient()
        {
            Name = "River Betty";
            PrimaryEffect = AllAlchemyEffects.DamageHealth.ScaleMagnitude(2.5);
            SecondaryEffect = AllAlchemyEffects.FortifyAlteration;
            TertiaryEffect = AllAlchemyEffects.Slow;
            QuaternaryEffect = AllAlchemyEffects.FortifyCarryWeight;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly RiverBettyIngredient RiverBetty = new RiverBettyIngredient();
    }
}