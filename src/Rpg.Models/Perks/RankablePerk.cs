using Rpg.Models.Skills;

namespace Rpg.Models.Perks
{
    public abstract class RankablePerk<T> : Perk<T>
        where T : ISkill
    {
        protected RankablePerk(int rank, string name)
            : base(name)
        {
            Rank = rank;
        }

        public int Rank { get; }
    }
}