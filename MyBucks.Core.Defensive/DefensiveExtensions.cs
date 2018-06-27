using System;

namespace MyBucks.Core.Defensive
{
    public static class DefensiveExtensions
    {
        public static StringDefender Defend(this string str, string parameterName)
        {
            return new StringDefender(str, parameterName);
        }

        public static IntDefender Defend(this int num, string parameterName)
        {
            return new IntDefender(num, parameterName);
        }
    }
}