using System;
using System.Collections.Generic;

namespace Horspool
{
    class Program
    {
        static void Main(string[] args)
        {
            Horspool horspool = new Horspool();
           /* String pattern = "aefa";
            String text = "abdcef";

            //horspool.patternPreprocess(pattern);
            horspool.fillShiftTable(pattern, text.ToLower());*/

            string txt = "It's the most wonderful time of the year";
            string pat = "1";

            List<int> result = horspool.find(txt, pat);

            for(int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("\nPattern found at index: " + result[i]);
            }

            if(result.Count == 0)
            {
                Console.WriteLine("\nPattern not found!");
            }
        }
    }
}
