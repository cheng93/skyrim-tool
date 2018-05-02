using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class ExperimenterPerk : RankablePerk<AlchemySkill>
    {
        public ExperimenterPerk(int rank)
            : base(rank, "Experimenter")
        {
            if (Rank < 1 || Rank > 3)
            {
                throw new ArgumentOutOfRangeException();
            }

            Description = GetDescription(Rank);
        }

        public override string Description { get; }

        private string GetDescription(int rank)
        {
            switch(rank)
            {
                case 1:
                    return "Eating an ingredient reveals first two effects.";
                case 2:
                    return "Eating an ingredient reveals first three effects.";
                case 3:
                    return "Eating an ingredient reveals all its effects.";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public partial class AlchemyPerks
    {
        public class ExperimenterPerks
        {
            public ExperimenterPerk One { get; } = new ExperimenterPerk(1);

            public ExperimenterPerk Two { get; } = new ExperimenterPerk(2);

            public ExperimenterPerk Three { get; } = new ExperimenterPerk(3);
        }

        public ExperimenterPerks Experimenter { get; } = new ExperimenterPerks();
    }
}