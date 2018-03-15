using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class EyeOfSabreCatIngredient : Ingredient
    {
        public EyeOfSabreCatIngredient()
        {
            Name = "Eye of Sabre Cat";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.RavageHealth;
            TertiaryEffect = AllAlchemyEffects.DamageMagicka;
            QuaternaryEffect = AllAlchemyEffects.RestoreHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly EyeOfSabreCatIngredient EyeOfSabreCat = new EyeOfSabreCatIngredient();
    }
}