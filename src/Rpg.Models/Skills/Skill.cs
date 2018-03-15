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
}