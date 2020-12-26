using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Horspool
{
    class Horspool
    {
        public List<int> find(string text, string pattern)
        {
            List<int> res = new List<int>();
            int textLength = text.Length;
            int patternLength = pattern.Length;

            if (patternLength > textLength)
            {
                return res;
            }

            if (pattern.Except(text).Any())
            {
                return res;
            }

            Dictionary<char, int> shiftTable = fillShiftTable(text, pattern);

            int index = patternLength - 1;
            while (index <= textLength - 1)
            {
                int k = 0;
                while (k <= patternLength - 1 && pattern[patternLength - 1 - k] == text[index - k])
                    k = k + 1;
                if (k == patternLength)
                {
                    res.Add(index - patternLength + 1);
                    index = index + shiftTable[text[index]];
                    continue;
                }
                else
                    index = index + shiftTable[text[index]];
            }
            return res;
        }

        private static Dictionary<char, int> fillShiftTable(string text, string pattern)
        {
            Dictionary<char, int> shiftTable = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (!shiftTable.Keys.Contains(c))
                    shiftTable.Add(c, pattern.Length);
            }

            for (int i = 0; i < pattern.Length - 1; i++)
            {
                shiftTable[pattern[i]] = pattern.Length - i - 1;
            }

            Console.WriteLine("Shift table: ");
            foreach (KeyValuePair<char, int> kvp in shiftTable)
            {
                Console.WriteLine("Char = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            return shiftTable;
        }
    }
}
