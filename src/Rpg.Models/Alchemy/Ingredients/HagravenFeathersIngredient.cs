using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HagravenFeathersIngredient : Ingredient
    {
        public HagravenFeathersIngredient()
        {
            Name = "Hagraven Feathers";
            PrimaryEffect = AllAlchemyEffects.DamageMagicka;
            SecondaryEffect = AllAlchemyEffects.FortifyConjuration;
            TertiaryEffect = AllAlchemyEffects.Frenzy;
            QuaternaryEffect = AllAlchemyEffects.WeaknessToShock;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HagravenFeathersIngredient HagravenFeathers = new HagravenFeathersIngredient();
    }
}