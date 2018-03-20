using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class GlowDustIngredient : Ingredient
    {
        public GlowDustIngredient()
        {
            Name = "Glow Dust";
            PrimaryEffect = AllAlchemyEffects.DamageMagicka;
            SecondaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
            TertiaryEffect = AllAlchemyEffects.FortifyDestruction;
            QuaternaryEffect = AllAlchemyEffects.ResistShock;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad73";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly GlowDustIngredient GlowDust = new GlowDustIngredient();
    }
}