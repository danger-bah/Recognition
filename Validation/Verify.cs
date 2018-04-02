using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation
{
    public static class Verify
    {
        public static bool Chars(string expression, string pattern)
        {
            return Chars(expression, pattern.ToCharArray());
        }

        public static bool Chars(string expression, char[] pattern)
        {
            foreach (char ch in expression)
                if (!pattern.Contains(ch))
                    return false;
            return true;
        }

        public static bool NotChars(string expression, char[] pattern)
        {
            foreach (char ch in expression)
                if (pattern.Contains(ch))
                    return false;
            return true;
        }

        public static bool RegexMatch(string expression, string pattern)
        {
            return Regex.IsMatch(expression, pattern);
        }
    }
}
