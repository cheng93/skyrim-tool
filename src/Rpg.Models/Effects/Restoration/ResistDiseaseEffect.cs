namespace Rpg.Models.Effects.Restoration
{
    public class ResistDiseaseEffect : Effect
    {
        public ResistDiseaseEffect()
            : base("Resist Disease")
        {
        }
    }

    public partial class RestorationEffects
    {
        public static readonly ResistDiseaseEffect ResistDisease = new ResistDiseaseEffect();
    }
}