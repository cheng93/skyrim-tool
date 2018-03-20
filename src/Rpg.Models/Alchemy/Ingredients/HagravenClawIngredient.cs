using Rpg.Models.Effects;
using Rpg.Models.Alchemy.Effects;

namespace Rpg.Models.Alchemy.Ingredients
{
    public class HagravenClawIngredient : Ingredient
    {
        public HagravenClawIngredient()
        {
            Name = "Hagraven Claw";
            PrimaryEffect = AllAlchemyEffects.ResistMagic;
            SecondaryEffect = AllAlchemyEffects.LingeringDamageMagicka;
            TertiaryEffect = AllAlchemyEffects.FortifyEnchanting;
            QuaternaryEffect = AllAlchemyEffects.FortifyBarter;
        }

        public override string Name { get; }

        public override string Id { get; } = "0006b689";

        public override IAlchemyEffect PrimaryEffect { get; }

        public override IAlchemyEffect SecondaryEffect { get; }

        public override IAlchemyEffect TertiaryEffect { get; }

        public override IAlchemyEffect QuaternaryEffect { get; }
    }

    public static partial class AllIngredients
    {
        public static readonly HagravenClawIngredient HagravenClaw = new HagravenClawIngredient();
    }
}