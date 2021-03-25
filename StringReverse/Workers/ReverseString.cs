using System;
using System.Linq;

namespace StringReverse
{
    internal class ReverseString
    {
        public char[] Reverse(string s)
        {
            char[] newArray = new char[s.ToCharArray().Length];
            int index = newArray.Length;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (s.Length > 1)
                {
                    if (char.IsLetter(s[index - 1]) || char.IsWhiteSpace(s[index - 1]))
                    {
                        newArray[i] = s[index - 1];
                        index--;

                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            return newArray;

        }
    }
}