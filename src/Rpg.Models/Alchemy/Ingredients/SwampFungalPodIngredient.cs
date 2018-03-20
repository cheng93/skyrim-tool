using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class SwampFungalPodIngredient : Ingredient
    {
        public SwampFungalPodIngredient()
        {
            Name = "Swamp Fungal Pod";
            PrimaryEffect = AllAlchemyEffects.ResistShock;
            SecondaryEffect = AllAlchemyEffects.LingeringDamageMagicka;
            TertiaryEffect = AllAlchemyEffects.Paralyze;
            QuaternaryEffect = AllAlchemyEffects.RestoreHealth;
        }

        public override string Name { get; }

        public override string Id { get; } = "0007e8b7";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly SwampFungalPodIngredient SwampFungalPod = new SwampFungalPodIngredient();
    }
}