using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;
using Rpg.Models.Extensions;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class JarrinRootIngredient : Ingredient
    {
        public JarrinRootIngredient()
        {
            Name = "Jarrin Root";
            PrimaryEffect = AllAlchemyEffects.DamageHealth.ScaleMagnitude(100);
            SecondaryEffect = AllAlchemyEffects.DamageMagicka;
            TertiaryEffect = AllAlchemyEffects.DamageStamina;
            QuaternaryEffect = AllAlchemyEffects.DamageMagickaRegeneration;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly JarrinRootIngredient JarrinRoot = new JarrinRootIngredient();
    }
}