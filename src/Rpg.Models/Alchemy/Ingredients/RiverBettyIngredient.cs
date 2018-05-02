using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class RiverBettyIngredient : Ingredient
    {
        public RiverBettyIngredient()
        {
            Name = "River Betty";
            PrimaryEffect = AllAlchemyEffects.DamageHealth.ScaleMagnitude(2.5M);
            SecondaryEffect = AllAlchemyEffects.FortifyAlteration;
            TertiaryEffect = AllAlchemyEffects.Slow;
            QuaternaryEffect = AllAlchemyEffects.FortifyCarryWeight;
        }

        public override string Name { get; }

        public override string Id { get; } = "00106e1a";

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