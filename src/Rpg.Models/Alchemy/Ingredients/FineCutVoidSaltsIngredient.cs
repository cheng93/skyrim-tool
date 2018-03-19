using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class FineCutVoidSaltsIngredient : Ingredient
    {
        public FineCutVoidSaltsIngredient()
        {
            Name = "Fine-Cut Void Salts";
            PrimaryEffect = AllAlchemyEffects.WeaknessToShock;
            SecondaryEffect = AllAlchemyEffects.ResistMagic;
            TertiaryEffect = AllAlchemyEffects.DamageHealth;
            QuaternaryEffect = AllAlchemyEffects.FortifyMagicka;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad60";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly FineCutVoidSaltsIngredient FineCutVoidSalts = new FineCutVoidSaltsIngredient();
    }
}