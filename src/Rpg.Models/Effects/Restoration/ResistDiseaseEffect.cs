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
        public ResistDiseaseEffect ResistDisease { get; } = new ResistDiseaseEffect();
    }
}