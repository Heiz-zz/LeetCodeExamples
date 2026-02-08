using System;
using System.Text;

namespace LeetCode_Examples
{
    class IntegerToRoman
    {
        public void ITR()
        {
            while(true)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if(num >= 1 && num <= 3999) { System.Console.WriteLine(ITRLogic(num)); } 
                else { System.Console.Write("Error: Enter number from 1 to 3999: "); }

                break;
            }

            Thread.Sleep(2000);
        }

        string ITRLogic(int num)
        {
            var values = new (int value, string symbol)[]
            {
                (1000, "M"), 
                (900, "CM"), (500, "D"), (400, "CD"), (100, "C"),
                (90, "XC"), (50, "L"), (40, "XL"), (10, "X"),
                (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
            };

            StringBuilder output = new StringBuilder();

            foreach(var (value, symbol) in values)
            {
                while(num >= value)
                {
                    num -= value;
                    output.Append(symbol);
                }

                if(num == 0) break;
            }

            return output.ToString();
        }
    }
}