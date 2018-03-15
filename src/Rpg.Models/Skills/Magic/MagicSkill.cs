using Rpg.Models.Specializations;

namespace Rpg.Models.Skills.Magic
{
    public abstract class MagicSkill : ISkill<MagicSpecialization>
    {
        protected MagicSkill(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}