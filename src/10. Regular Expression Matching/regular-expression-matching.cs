using System;
using System.Threading;

namespace LeetCode_Examples
{
    class regular_expression_matching
    {
        public void REM()
        {
            var s = Console.ReadLine();
            var p = Console.ReadLine();

            bool output = REMLogic(s, p, 0, 0);
            System.Console.WriteLine(output);

            Thread.Sleep(2000);
        }

        private bool REMLogic(string s, string p, int s_i, int p_i)
        {
            if(s_i >= s.Length && p_i >= p.Length)
            {
                return true;
            }

            if(p_i >= p.Length)
            {
                return false;
            }

            bool match = s_i < s.Length && (s[s_i] == p[p_i] || p[p_i] == '.');

            regular_expression_matching matching = new regular_expression_matching();

            if(p_i + 1 < p.Length && p[p_i + 1] == '*')
            {
                if(matching.REMLogic(s, p, s_i, p_i + 2))
                {
                    return true;
                }

                if(match)
                { 
                    return matching.REMLogic(s, p, s_i + 1, p_i); 
                }

                return false; 
            }

            if (match)
            {
                return matching.REMLogic(s, p, s_i + 1, p_i + 1);
            }

            return false;
        }
    }
}