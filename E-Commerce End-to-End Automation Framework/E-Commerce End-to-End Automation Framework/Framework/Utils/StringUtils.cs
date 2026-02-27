using System;
using System.Text.RegularExpressions;

namespace E_Commerce_End_to_End_Automation_Framework.Framework
{
    internal class StringUtils
    {
        private const string CurrencyRegex = "[^\\d.]";

        public static double GetDoubleFromString(string value)
        {
            return Convert.ToDouble(Regex.Replace(value, CurrencyRegex, ""));
        }
    }
}