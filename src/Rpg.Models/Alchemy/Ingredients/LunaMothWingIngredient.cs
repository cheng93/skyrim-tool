using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class LunaMothWingIngredient : Ingredient
    {
        public LunaMothWingIngredient()
        {
            Name = "Luna Moth Wing";
            PrimaryEffect = AllAlchemyEffects.DamageMagicka;
            SecondaryEffect = AllAlchemyEffects.FortifyLightArmor;
            TertiaryEffect = AllAlchemyEffects.RegenerateHealth;
            QuaternaryEffect = AllAlchemyEffects.Invisibility;
        }

        public override string Name { get; }

        public override string Id { get; } = "000727df";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly LunaMothWingIngredient LunaMothWing = new LunaMothWingIngredient();
    }
}