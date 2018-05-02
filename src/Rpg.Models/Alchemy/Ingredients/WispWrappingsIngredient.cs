using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class WispWrappingsIngredient : Ingredient
    {
        public WispWrappingsIngredient()
        {
            Name = "Wisp Wrappings";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyDestruction;
            TertiaryEffect = AllAlchemyEffects.FortifyCarryWeight;
            QuaternaryEffect = AllAlchemyEffects.ResistMagic;
        }

        public override string Name { get; }

        public override string Id { get; } = "0006bc0e";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly WispWrappingsIngredient WispWrappings = new WispWrappingsIngredient();
    }
}