using System;
using System.Text.RegularExpressions;

namespace MarvelBackend.Utils
{
    public static class ValidateExts
    {
        internal static void ValidateArrays(this string param,
                                           string paramName)
        {
            if (!string.IsNullOrWhiteSpace(param))
            {
                if (!Regex.IsMatch(param, @"^(\,?[\W\d]+)*$", RegexOptions.CultureInvariant))
                    throw new ArgumentException($"'{paramName}' invalid value = {param}", paramName);
            }
        }
    }
}
