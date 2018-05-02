using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class DaedraHeartIngredient : Ingredient
    {
        public DaedraHeartIngredient()
        {
            Name = "Daedra Heart";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.RavageStamina;
            TertiaryEffect = AllAlchemyEffects.RegenerateStamina;
            QuaternaryEffect = AllAlchemyEffects.WeaknessToShock;
        }

        public override string Name { get; }

        public override string Id { get; } = "0003ad5b";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly DaedraHeartIngredient DaedraHeart = new DaedraHeartIngredient();
    }
}