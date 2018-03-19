using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class DragonsTongueIngredient : Ingredient
    {
        public DragonsTongueIngredient()
        {
            Name = "Dragon's Tongue";
            PrimaryEffect = AllAlchemyEffects.ResistFire;
            SecondaryEffect = AllAlchemyEffects.FortifyBarter;
            TertiaryEffect = AllAlchemyEffects.FortifyIllusion;
            QuaternaryEffect = AllAlchemyEffects.FortifyTwoHanded;
        }

        public override string Name { get; }

        public override string Id { get; } = "000889a2";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly DragonsTongueIngredient DragonsTongue = new DragonsTongueIngredient();
    }
}