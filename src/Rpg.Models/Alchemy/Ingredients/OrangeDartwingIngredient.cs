using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class OrangeDartwingIngredient : Ingredient
    {
        public OrangeDartwingIngredient()
        {
            Name = "Orange Dartwing";
            PrimaryEffect = AllAlchemyEffects.RestoreStamina;
            SecondaryEffect = AllAlchemyEffects.RavageMagicka;
            TertiaryEffect = AllAlchemyEffects.FortifyPickpocket;
            QuaternaryEffect = AllAlchemyEffects.LingeringDamageHealth;
        }

        public override string Name { get; }

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly OrangeDartwingIngredient OrangeDartwing = new OrangeDartwingIngredient();
    }
}