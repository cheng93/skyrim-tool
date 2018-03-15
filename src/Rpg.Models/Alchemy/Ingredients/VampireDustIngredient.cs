using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class VampireDustIngredient : Ingredient
    {
        public VampireDustIngredient()
        {
            Name = "Vampire Dust";
            PrimaryEffect = AllAlchemyEffects.Invisibility;
            SecondaryEffect = AllAlchemyEffects.RestoreMagicka;
            TertiaryEffect = AllAlchemyEffects.RegenerateHealth;
            QuaternaryEffect = AllAlchemyEffects.CureDisease;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly VampireDustIngredient VampireDust = new VampireDustIngredient();
    }
}