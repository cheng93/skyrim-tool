using System;
using FluentAssertions;
using Rpg.Logic.Alchemy;
using Rpg.Models.Perks;
using Rpg.Models.Skills.Stealth;
using Xunit;

namespace Rpg.Logic.Tests.Alchemy.AlchemyPerkCollectionTests
{
    public class Test
    {
        private AlchemyPerkCollection Subject = new AlchemyPerkCollection();

        [Fact]
        public void ValidItems()
        {
            var perkOne = AllPerks.Alchemy.Alchemist.One;
            var perkTwo = AllPerks.Alchemy.Benefactor;

            Subject.Add(perkOne);
            Subject.Add(perkTwo);

            var expected = new IPerk<AlchemySkill>[] 
            {
                perkOne,
                perkTwo
            };

            Subject.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void DuplicatePerks()
        {
            var perkOne = AllPerks.Alchemy.Alchemist.One;
            var perkTwo = AllPerks.Alchemy.Alchemist.Two;

            Subject.Add(perkOne);

            Assert.Throws<ArgumentException>(() => Subject.Add(perkTwo));
        }
    }
}