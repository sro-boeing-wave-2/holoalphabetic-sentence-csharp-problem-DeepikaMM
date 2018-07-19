using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            char[] inputString =input.ToLower().ToCharArray();
            if (inputString == null)
                return false;
            else
            {
                for(int i=0;i<alphabets.Length;i++)
                {
                    if(!input.Contains(alphabets[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
