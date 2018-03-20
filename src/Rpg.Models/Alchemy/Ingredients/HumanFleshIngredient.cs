using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HumanFleshIngredient : Ingredient
    {
        public HumanFleshIngredient()
        {
            Name = "Human Flesh";
            PrimaryEffect = AllAlchemyEffects.DamageHealth;
            SecondaryEffect = AllAlchemyEffects.Paralyze;
            TertiaryEffect = AllAlchemyEffects.RestoreMagicka;
            QuaternaryEffect = AllAlchemyEffects.FortifySneak;
        }

        public override string Name { get; }

        public override string Id { get; } = "001016b3";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HumanFleshIngredient HumanFlesh = new HumanFleshIngredient();
    }
}