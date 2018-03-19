using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class TundraCottonIngredient : Ingredient
    {
        public TundraCottonIngredient()
        {
            Name = "Tundra Cotton";
            PrimaryEffect = AllAlchemyEffects.ResistMagic;
            SecondaryEffect = AllAlchemyEffects.FortifyMagicka;
            TertiaryEffect = AllAlchemyEffects.FortifyBlock;
            QuaternaryEffect = AllAlchemyEffects.FortifyBarter;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003f7f8";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly TundraCottonIngredient TundraCotton = new TundraCottonIngredient();
    }
}