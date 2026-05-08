using System;

namespace Practika11
{
    static class StringExtensions
    {
        public static string Capitalize(this string str)
        {
            if (str == null || str.Length == 0)
            {
                return str ?? "";
            }

            string result = "";
            bool newWord = true;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c == ' ')
                {
                    result += c;
                    newWord = true;
                }
                else
                {
                    if (newWord == true)
                    {
                        result += char.ToUpper(c);
                        newWord = false;
                    }
                    else
                    {
                        result += char.ToLower(c);
                    }
                }
            }
            return result;
        }
    }
}
