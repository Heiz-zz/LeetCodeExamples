using System;
using System.Linq;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

// https://leetcode.com/problems/string-to-integer-atoi/description/

namespace LeetCode_Examples
{
    class StringToIntegerAtoi
    {
        public void StringToInteger()
        {
            while (true)
            {
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    StringToIntegerAtoi atoi = new StringToIntegerAtoi();
                    int output = atoi.Solution(input);
                    System.Console.WriteLine($"Answer: {output}");   
                    break;
                }
            }
            Thread.Sleep(2000);
        }

        private int Solution(string input)
        {
            char minus = '+';
            List<char> Char = input.ToList();
            List<char> output = [];
            int index = 0;

            while(index < Char.Count)
            {
                if(Char[index] == '-')
                {
                    minus = '-';
                }
                if(Char[index] == ' ' || Char[index] == '-' || Char[index] == '+')
                {
                    Char.RemoveAt(index);
                }
                else
                {
                    index++;
                }
            }
            index = 0;

            while(index < Char.Count)
            {
                if (char.IsDigit(Char[index]))
                {
                    output.Add(Char[index]);
                }
                index++;
            }

            if(minus == '-') { output.Insert(0, minus); }

            return int.Parse(string.Join("", output));
        }
    }
}