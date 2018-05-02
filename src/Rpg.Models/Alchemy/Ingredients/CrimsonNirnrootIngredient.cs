using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class CrimsonNirnrootIngredient : Ingredient
    {
        public CrimsonNirnrootIngredient()
        {
            Name = "Crimson Nirnroot";
            PrimaryEffect = AllAlchemyEffects.DamageHealth.ScaleMagnitude(3);
            SecondaryEffect = AllAlchemyEffects.DamageStamina.ScaleMagnitude(3);
            TertiaryEffect = AllAlchemyEffects.Invisibility;
            QuaternaryEffect = AllAlchemyEffects.ResistMagic;
        }

        public override string Name { get; }

        public override string Id { get; } = "000b701a";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly CrimsonNirnrootIngredient CrimsonNirnroot = new CrimsonNirnrootIngredient();
    }
}