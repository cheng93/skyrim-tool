namespace Rpg.Models.Effects.Restoration
{
    public class FortifyCarryWeightEffect : Effect
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