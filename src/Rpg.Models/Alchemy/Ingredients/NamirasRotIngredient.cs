using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class NamirasRotIngredient : Ingredient
    {
        public NamirasRotIngredient()
        {
            Name = "Namira's Rot";
            PrimaryEffect = AllAlchemyEffects.DamageMagicka;
            SecondaryEffect = AllAlchemyEffects.FortifyLockpicking;
            TertiaryEffect = AllAlchemyEffects.Fear;
            QuaternaryEffect = AllAlchemyEffects.RegenerateHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly NamirasRotIngredient NamirasRot = new NamirasRotIngredient();
    }
}