using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class CreepClusterIngredient : Ingredient
    {
        public CreepClusterIngredient()
        {
            Name = "Creep Cluster";
            PrimaryEffect = AllAlchemyEffects.RestoreMagicka;
            SecondaryEffect = AllAlchemyEffects.DamageStaminaRegeneration;
            TertiaryEffect = AllAlchemyEffects.FortifyCarryWeight;
            QuaternaryEffect = AllAlchemyEffects.WeaknessToMagic;
        }

        public override string Name { get; }

        public override string Id { get; } = "000b2183";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly CreepClusterIngredient CreepCluster = new CreepClusterIngredient();
    }
}