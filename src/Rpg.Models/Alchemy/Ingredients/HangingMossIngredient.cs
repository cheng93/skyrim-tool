using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HangingMossIngredient : Ingredient
    {
        public HangingMossIngredient()
        {
            Name = "Hanging Moss";
            PrimaryEffect = AllAlchemyEffects.DamageMagicka;
            SecondaryEffect = AllAlchemyEffects.FortifyHealth;
            TertiaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
            QuaternaryEffect = AllAlchemyEffects.FortifyOneHanded;
        }

        public override string Name { get; }

        public override string Id { get; } = "00057f91s";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HangingMossIngredient HangingMoss = new HangingMossIngredient();
    }
}