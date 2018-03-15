using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class ChickensEggIngredient : Ingredient
    {
        public ChickensEggIngredient()
        {
            Name = "Chicken's Egg";
            PrimaryEffect = AllAlchemyEffects.ResistMagic;
            SecondaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
            TertiaryEffect = AllAlchemyEffects.Waterbreathing;
            QuaternaryEffect = AllAlchemyEffects.LingeringDamageStamina;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly ChickensEggIngredient ChickensEgg = new ChickensEggIngredient();
    }
}