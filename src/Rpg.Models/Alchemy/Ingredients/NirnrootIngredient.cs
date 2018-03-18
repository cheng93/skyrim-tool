using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class NirnrootIngredient : Ingredient
    {
        public NirnrootIngredient()
        {
            Name = "Nirnroot";
            PrimaryEffect = AllAlchemyEffects.DamageHealth.ScaleCost(12.6);
            SecondaryEffect = AllAlchemyEffects.DamageStamina;
            TertiaryEffect = AllAlchemyEffects.Invisibility;
            QuaternaryEffect = AllAlchemyEffects.ResistMagic;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly NirnrootIngredient Nirnroot = new NirnrootIngredient();
    }
}