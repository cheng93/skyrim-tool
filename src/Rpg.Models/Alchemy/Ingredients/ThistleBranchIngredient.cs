using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Alchemy.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class ThistleBranchIngredient : Ingredient
    {
        public ThistleBranchIngredient()
        {
            Name = "Thistle Branch";
            PrimaryEffect = AllAlchemyEffects.ResistFrost;
            SecondaryEffect = AllAlchemyEffects.RavageStamina;
            TertiaryEffect = AllAlchemyEffects.ResistPoison.ScaleMagnitude(0.75);
            QuaternaryEffect = AllAlchemyEffects.FortifyHeavyArmor;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly ThistleBranchIngredient ThistleBranch = new ThistleBranchIngredient();
    }
}