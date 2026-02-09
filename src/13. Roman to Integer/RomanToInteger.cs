using System;
using System.Text;

namespace LeetCode_Examples
{
    class RomanToInteger
    {
        public void RTI()
        {
            while(true)
            {
                string? s = Console.ReadLine();

                if(!string.IsNullOrEmpty(s))
                {
                    int output = RTILogic(s);
                    System.Console.WriteLine(output);
                }

                break;
            }

            Thread.Sleep(2000);
        }

        int RTILogic(string s)
        {
            var values = new (int value, string symbol)[]
            {
                (1000, "M"), 
                (900, "CM"), (500, "D"), (400, "CD"), (100, "C"),
                (90, "XC"), (50, "L"), (40, "XL"), (10, "X"),
                (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
            };

            var dic = values.ToDictionary(v => v.symbol, v => v.value);

            int output = 0;
            string[] ss = s.Select(c => char.ToString(c)).ToArray();

            foreach(var symbol in s)
            {
                if(dic.TryGetValue(symbol.ToString(), out int value))
                {
                    output += value;
                }
            }

            return output;
        }
    }
}