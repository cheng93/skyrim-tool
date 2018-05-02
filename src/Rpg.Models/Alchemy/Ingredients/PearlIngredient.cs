using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class PearlIngredient : Ingredient
    {
        public PearlIngredient()
        {
            Name = "Pearl";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyBlock;
            TertiaryEffect = AllAlchemyEffects.RestoreMagicka;
            QuaternaryEffect = AllAlchemyEffects.ResistShock;
        }

        public override string Name { get; }

        public override string Id { get; } = "000854fe";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly PearlIngredient Pearl = new PearlIngredient();
    }
}