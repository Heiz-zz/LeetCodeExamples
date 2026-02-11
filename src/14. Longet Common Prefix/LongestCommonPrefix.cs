using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode_Examples
{
    class LongestCommonPrefix
    {
        public void LCP()
        {
            while(true)
            {
                System.Console.Write("Enter words separated by space: ");
                string? words = Console.ReadLine();

                if (!string.IsNullOrEmpty(words))
                {
                    string output = LPCLogic(words.Split(' '));
                    System.Console.WriteLine(output);
                    break;
                } else System.Console.WriteLine("Error! String is empty!");
            }
        }

        string LPCLogic(string[] strs)
        {
            StringBuilder output = new StringBuilder();
            int q = 0;
            bool stop = true;

            for(int i = 0; i < strs.Min(s => s.Length) && stop; i++)
            {
                char _char = strs[q][i];
                bool allMatch = true;
                q++;

                for(int w = 1; w < strs.Length; w++)
                {
                    if(strs[w][i] != _char)
                    {
                        allMatch = false;
                        break;
                    }
                }

                if(allMatch)
                {
                    output.Append(_char);        
                }
                else
                {
                    stop = false;
                }
            }

            return output.ToString();
        }
    }
}