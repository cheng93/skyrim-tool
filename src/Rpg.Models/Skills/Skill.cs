using Rpg.Models.Common;
using Rpg.Models.Specializations;

namespace Rpg.Models.Skills
{
    public interface ISkill<T> : IHasName
        where T : ISpecialization
    {
        
    }
}