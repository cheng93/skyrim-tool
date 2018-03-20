using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class FrostMirriamIngredient : Ingredient
    {
        public FrostMirriamIngredient()
        {
            Name = "Frost Mirriam";
            PrimaryEffect = AllAlchemyEffects.ResistFrost;
            SecondaryEffect = AllAlchemyEffects.FortifySneak;
            TertiaryEffect = AllAlchemyEffects.RavageMagicka;
            QuaternaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
        }

        public override string Name { get; }

        public override string Id { get; } = "00034d32";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly FrostMirriamIngredient FrostMirriam = new FrostMirriamIngredient();
    }
}