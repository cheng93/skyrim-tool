namespace Rpg.Models.Effects.Restoration
{
    public class FortifyCarryWeightEffect : Effect<FortifyCarryWeightEffect>
    {
        public FortifyCarryWeightEffect() 
            : base("Fortify Carry Weight")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public static readonly FortifyCarryWeightEffect FortifyCarryWeight = new FortifyCarryWeightEffect();
    }
}