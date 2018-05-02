using System;
using Rpg.Models.Skills.Stealth;

namespace Rpg.Models.Perks.Alchemy
{
    public class AlchemistPerk : RankablePerk<AlchemySkill>
    {
        public AlchemistPerk(int rank)
            : base(rank, "Alchemist")
        {
            if (Rank < 1 || Rank > 5)
            {
                throw new ArgumentOutOfRangeException();
            }

            Description = GetDescription(Rank);
        }

        public override string Description { get; }

        private string GetDescription(int rank)
        {
            var word = rank == 5
                ? "twice"
                : $"{rank * 20}%";

            return $"Potions and poisons you make are {word} stronger.";
        }
    }

    public partial class AlchemyPerks
    {
        public class AlchemistPerks
        {
            public AlchemistPerk One { get; } = new AlchemistPerk(1);

            public AlchemistPerk Two { get; } = new AlchemistPerk(2);

            public AlchemistPerk Three { get; } = new AlchemistPerk(3);

            public AlchemistPerk Four { get; } = new AlchemistPerk(4);

            public AlchemistPerk Five { get; } = new AlchemistPerk(5);
        }

        public AlchemistPerks Alchemist { get; } = new AlchemistPerks();
    }
}