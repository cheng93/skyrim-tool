using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class FalmerEarIngredient : Ingredient
    {
        public FalmerEarIngredient()
        {
            Name = "Falmer Ear";
            PrimaryEffect = AllAlchemyEffects.DamageHealth;
            SecondaryEffect = AllAlchemyEffects.Frenzy;
            TertiaryEffect = AllAlchemyEffects.ResistPoison;
            QuaternaryEffect = AllAlchemyEffects.FortifyLockpicking;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad5d";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly FalmerEarIngredient FalmerEar = new FalmerEarIngredient();
    }
}