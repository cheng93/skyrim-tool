using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class TorchbugThoraxIngredient : Ingredient
    {
        public TorchbugThoraxIngredient()
        {
            Name = "Torchbug Thorax";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.LingeringDamageMagicka;
            TertiaryEffect = AllAlchemyEffects.WeaknessToMagic;
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
        public static readonly TorchbugThoraxIngredient TorchbugThorax = new TorchbugThoraxIngredient();
    }
}