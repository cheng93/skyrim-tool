using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HumanHeartIngredient : Ingredient
    {
        public HumanHeartIngredient()
        {
            Name = "Human Heart";
            PrimaryEffect = AllAlchemyEffects.DamageHealth;
            SecondaryEffect = AllAlchemyEffects.DamageMagicka;
            TertiaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
            QuaternaryEffect = AllAlchemyEffects.Frenzy;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HumanHeartIngredient HumanHeart = new HumanHeartIngredient();
    }
}