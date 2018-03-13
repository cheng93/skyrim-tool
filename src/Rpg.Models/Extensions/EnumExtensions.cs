using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Rpg.Models.Extensions
{
    public static class EnumExtensions
    {
        public static string ToPresentableString(this Enum e)
        {
            return e
                .GetType()
                .GetMember(e.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<DescriptionAttribute>()
                ?.Description
                ?? e.ToString();
        }
    }
}