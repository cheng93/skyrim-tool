namespace Rpg.Models.Effects.Restoration
{
    public class CureDiseaseEffect : Effect<CureDiseaseEffect>
    {
        public CureDiseaseEffect() 
            : base("Cure Disease")
        {
        }
    }

    public partial class RestorationEffects 
    {
        public CureDiseaseEffect CureDisease { get; } = new CureDiseaseEffect();
    }
}