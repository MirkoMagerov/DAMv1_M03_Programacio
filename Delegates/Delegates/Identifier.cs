using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace Delegates
{
    public class Identifier
    {
        // 1
        public static string Clean(string msg)
        {
            if (string.IsNullOrEmpty(msg)) return msg;
            msg = msg.Replace(" ", "_");
            Regex controlCharRegex = new Regex(@"[\x00-\x1F\x7F]");
            msg = controlCharRegex.Replace(msg, "CTRL");

            bool convertToUpper = false;
            char[] modifiedChars = msg.ToCharArray();

            for (int i = 0; i < modifiedChars.Length; i++)
            {
                if (convertToUpper)
                {
                    modifiedChars[i] = Char.ToUpper(modifiedChars[i]);
                    convertToUpper = false;
                }
                if (modifiedChars[i] == '-')
                {
                    convertToUpper = true;
                }
            }

            string modifiedMsg = new string(modifiedChars);
            modifiedMsg = Regex.Replace(modifiedMsg, @"[^\u1F600-\u1F64F]", "");
            modifiedMsg = Regex.Replace(modifiedMsg, @"[0-9]*", "");
            modifiedMsg = Regex.Replace(modifiedMsg, @"[α-ωΑ-Ω]*", "");
            return modifiedMsg;
        }
    }
}
