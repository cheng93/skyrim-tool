using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class CyrodilicSpadetailIngredient : Ingredient
    {
        public CyrodilicSpadetailIngredient()
        {
            Name = "Cyrodilic Spadetail";
            PrimaryEffect = AllAlchemyEffects.DamageStamina;
            SecondaryEffect = AllAlchemyEffects.FortifyRestoration;
            TertiaryEffect = AllAlchemyEffects.Fear;
            QuaternaryEffect = AllAlchemyEffects.RavageHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly CyrodilicSpadetailIngredient CyrodilicSpadetail = new CyrodilicSpadetailIngredient();
    }
}