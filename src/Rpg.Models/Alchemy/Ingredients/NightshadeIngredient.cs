using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class NightshadeIngredient : Ingredient
    {
        public NightshadeIngredient()
        {
            Name = "Nightshade";
            PrimaryEffect = AllAlchemyEffects.DamageHealth;
            SecondaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
            TertiaryEffect = AllAlchemyEffects.LingeringDamageStamina;
            QuaternaryEffect = AllAlchemyEffects.FortifyDestruction.ScaleMagnitude(0.8);
        }

        public override string Name { get; }

        public override string Id { get; } = "0002f44c";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly NightshadeIngredient Nightshade = new NightshadeIngredient();
    }
}