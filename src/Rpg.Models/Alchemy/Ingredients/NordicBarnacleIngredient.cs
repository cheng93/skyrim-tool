using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class NordicBarnacleIngredient : Ingredient
    {
        public NordicBarnacleIngredient()
        {
            Name = "Nordic Barnacle";
            PrimaryEffect = AllAlchemyEffects.DamageMagicka;
            SecondaryEffect = AllAlchemyEffects.Waterbreathing;
            TertiaryEffect = AllAlchemyEffects.RegenerateHealth;
            QuaternaryEffect = AllAlchemyEffects.FortifyPickpocket;
        }

        public override string Name { get; }

        public override string Id { get; } = "0007edf5";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly NordicBarnacleIngredient NordicBarnacle = new NordicBarnacleIngredient();
    }
}