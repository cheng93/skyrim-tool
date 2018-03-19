using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class GrassPodIngredient : Ingredient
    {
        public GrassPodIngredient()
        {
            Name = "Grass Pod";
            PrimaryEffect = AllAlchemyEffects.ResistPoison;
            SecondaryEffect = AllAlchemyEffects.RavageMagicka;
            TertiaryEffect = AllAlchemyEffects.FortifyAlteration;
            QuaternaryEffect = AllAlchemyEffects.RestoreMagicka;
        }

        public override string Name { get; }

        public override string Id { get; } = "00083e64";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly GrassPodIngredient GrassPod = new GrassPodIngredient();
    }
}