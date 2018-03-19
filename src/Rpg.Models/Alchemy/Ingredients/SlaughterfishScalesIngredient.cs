using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SlaughterfishScalesIngredient : Ingredient
    {
        public SlaughterfishScalesIngredient()
        {
            Name = "Slaughterfish Scales";
            PrimaryEffect = AllAlchemyEffects.ResistFrost;
            SecondaryEffect = AllAlchemyEffects.LingeringDamageHealth;
            TertiaryEffect = AllAlchemyEffects.FortifyHeavyArmor;
            QuaternaryEffect = AllAlchemyEffects.FortifyBlock;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad70";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SlaughterfishScalesIngredient SlaughterfishScales = new SlaughterfishScalesIngredient();
    }
}