
using System.Text.RegularExpressions;

namespace Enum_Struct_Sealed.Helpers.Extensions
{
    internal static class Regexs
    {
        public static bool CheckTextWithRegex(this string str,string patern)
        {
            return Regex.IsMatch(str,patern);
        }


    }
}
