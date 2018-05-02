using Rpg.Models.Common;
using Rpg.Models.Specializations;

namespace Rpg.Models.Skills
{
    public interface ISkill : IHasName
    {

    }

    public interface ISkill<T> : ISkill
        where T : ISpecialization
    {

    }

    public abstract class Skill<T> : ISkill<T>
        where T : ISpecialization
    {
        protected Skill(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}