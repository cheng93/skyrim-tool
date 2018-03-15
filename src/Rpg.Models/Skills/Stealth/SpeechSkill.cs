namespace Rpg.Models.Skills.Stealth
{
    public class SpeechSkill : StealthSkill
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