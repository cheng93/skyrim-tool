using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SmallPearlIngredient : Ingredient
    {
        public SmallPearlIngredient()
        {
            Name = "Small Pearl";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyOneHanded;
            TertiaryEffect = AllAlchemyEffects.FortifyRestoration;
            QuaternaryEffect = AllAlchemyEffects.ResistFrost;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SmallPearlIngredient SmallPearl = new SmallPearlIngredient();
    }
}