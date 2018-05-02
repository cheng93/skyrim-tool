using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SmallAntlersIngredient : Ingredient
    {
        public SmallAntlersIngredient()
        {
            Name = "Small Antlers";
            PrimaryEffect = AllAlchemyEffects.WeaknessToPoison;
            SecondaryEffect = AllAlchemyEffects.FortifyRestoration;
            TertiaryEffect = AllAlchemyEffects.LingeringDamageStamina;
            QuaternaryEffect = AllAlchemyEffects.DamageHealth;
        }

        public override string Name { get; }

        public override string Id { get; } = "0006bc0b";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SmallAntlersIngredient SmallAntlers = new SmallAntlersIngredient();
    }
}