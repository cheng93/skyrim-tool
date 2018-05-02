using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class BeehiveHuskIngredient : Ingredient
    {
        public BeehiveHuskIngredient()
        {
            Name = "Beehive Husk";
            PrimaryEffect = AllAlchemyEffects.ResistPoison.ScaleMagnitude(0.5M);
            SecondaryEffect = AllAlchemyEffects.FortifyLightArmor;
            TertiaryEffect = AllAlchemyEffects.FortifySneak;
            QuaternaryEffect = AllAlchemyEffects.FortifyDestruction;
        }

        public override string Name { get; }

        public override string Id { get; } = "000a9191";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly BeehiveHuskIngredient BeehiveHusk = new BeehiveHuskIngredient();
    }
}