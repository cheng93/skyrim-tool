using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Stealth
{
    public class SpeechSkill : Skill<StealthSpecialization>
    {
        public SpeechSkill()
            : base("Speech")
        {
        }
    }

    public partial class StealthSkills
    {
        public SpeechSkill Speech { get; } = new SpeechSkill();
    }
}