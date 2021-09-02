using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace VehicleSales.Logic
{
    public static class Formatter
    {
        public static string RemoveCurrencyFormatting(string input)
        {
            var regex = new Regex("\\\"(.*?)\\\"");
            var output = regex.Replace(input, m => m.Value.Replace(",", "")).Replace("\"", "");
            return output;
        }
    }
}
