namespace Rpg.Models.Effects.Restoration
{
    public class ResistDiseaseEffect : Effect<ResistDiseaseEffect>
    {
        public ResistDiseaseEffect()
            : base("Resist Disease")
        {
        }
    }

    public partial class RestorationEffects
    {
        public ResistDiseaseEffect ResistDisease { get; } = new ResistDiseaseEffect();
    }
}