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
        public FortifyCarryWeightEffect FortifyCarryWeight { get; } = new FortifyCarryWeightEffect();
    }
}