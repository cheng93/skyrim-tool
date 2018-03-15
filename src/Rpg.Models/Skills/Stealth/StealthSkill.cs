using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Stealth
{
    public abstract class StealthSkill : ISkill<StealthSpecialization>
    {
        protected StealthSkill(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}