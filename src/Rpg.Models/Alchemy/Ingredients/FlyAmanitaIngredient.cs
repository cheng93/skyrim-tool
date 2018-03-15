using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class FlyAmanitaIngredient : Ingredient
    {
        public FlyAmanitaIngredient()
        {
            Name = "Fly Amanita";
            PrimaryEffect = AllAlchemyEffects.ResistFire;
            SecondaryEffect = AllAlchemyEffects.FortifyTwoHanded;
            TertiaryEffect = AllAlchemyEffects.Frenzy;
            QuaternaryEffect = AllAlchemyEffects.RegenerateStamina;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly FlyAmanitaIngredient FlyAmanita = new FlyAmanitaIngredient();
    }
}