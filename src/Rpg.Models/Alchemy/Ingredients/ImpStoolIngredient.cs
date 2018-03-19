using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class ImpStoolIngredient : Ingredient
    {
        public ImpStoolIngredient()
        {
            Name = "Imp Stool";
            PrimaryEffect = AllAlchemyEffects.DamageHealth;
            SecondaryEffect = AllAlchemyEffects.LingeringDamageHealth;
            TertiaryEffect = AllAlchemyEffects.Paralyze;
            QuaternaryEffect = AllAlchemyEffects.RestoreHealth.ScaleMagnitude(0.6);
        }

        public override string Name { get; }

        public override string Id { get; } = "0004da23";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly ImpStoolIngredient ImpStool = new ImpStoolIngredient();
    }
}