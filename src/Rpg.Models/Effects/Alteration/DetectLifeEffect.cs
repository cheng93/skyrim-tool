namespace Rpg.Models.Effects.Alteration
{
    public class DetectLifeEffect : Effect
    {
        public DetectLifeEffect() 
            : base("Detect Life")
        {
        }
    }

    public partial class AlterationEffects 
    {
        public DetectLifeEffect DetectLife { get; } = new DetectLifeEffect();
    }
}