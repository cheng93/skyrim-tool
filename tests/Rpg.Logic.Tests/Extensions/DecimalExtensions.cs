namespace Rpg.Logic.Tests.Extensions
{
    internal static class DecimalExtensions
    {
        public static decimal NonZeroOrOne(this decimal e) => e == 0 ? 1 : e;
    }
}