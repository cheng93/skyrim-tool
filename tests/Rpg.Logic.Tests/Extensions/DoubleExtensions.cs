namespace Rpg.Logic.Tests.Extensions
{
    internal static class DoubleExtensions
    {
        public static double NonZeroOrOne(this double e) => e == 0 ? 1 : e;
    }
}