using System.Collections.Generic;

namespace Rpg.Models.Common
{
    public class IHasIdEqualityComparer : IEqualityComparer<IHasId>
    {
        public bool Equals(IHasId x, IHasId y) => x?.Id.Equals(y?.Id) ?? false;

        public int GetHashCode(IHasId obj) => obj?.Id.GetHashCode() ?? 0;
    }
}