using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class VoidSaltsIngredient : Ingredient
    {
        public VoidSaltsIngredient()
        {
            Name = "Void Salts";
            PrimaryEffect = AllAlchemyEffects.WeaknessToShock;
            SecondaryEffect = AllAlchemyEffects.ResistMagic;
            TertiaryEffect = AllAlchemyEffects.DamageHealth;
            QuaternaryEffect = AllAlchemyEffects.FortifyMagicka;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly VoidSaltsIngredient VoidSalts = new VoidSaltsIngredient();
    }
}