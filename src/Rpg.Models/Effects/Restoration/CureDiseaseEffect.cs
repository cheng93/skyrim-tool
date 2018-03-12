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
        public static readonly CureDiseaseEffect CureDisease = new CureDiseaseEffect();
    }
}