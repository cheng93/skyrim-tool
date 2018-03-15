using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SlaughterfishEggIngredient : Ingredient
    {
        public SlaughterfishEggIngredient()
        {
            Name = "Slaughterfish Egg";
            PrimaryEffect = AllAlchemyEffects.ResistPoison;
            SecondaryEffect = AllAlchemyEffects.FortifyPickpocket;
            TertiaryEffect = AllAlchemyEffects.LingeringDamageHealth;
            QuaternaryEffect = AllAlchemyEffects.FortifyStamina;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SlaughterfishEggIngredient SlaughterfishEgg = new SlaughterfishEggIngredient();
    }
}