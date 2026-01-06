using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LeetCode_Examples
{
    class ReverseInteger
    {
        public void Reverse_Integer()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            ReverseInteger qp = new ReverseInteger();
            System.Console.WriteLine($"Answer: {qp.Solution(x)}");   
        }

        int Solution(int x)
        {
            char minus = '+';
            int output;
            
            string input = Convert.ToString(x);

            char[] Char = input.ToCharArray();
            var CheckingForMinus = Convert.ToString(Char.GetValue(0));
            if (CheckingForMinus == "-")
            {
                minus = '-';
                input = input.Remove(0, 1);
            }

            byte[] q = input.Select(c => byte.Parse(c.ToString())).ToArray();

            Array.Reverse(q);
            byte Null = Convert.ToByte(q.GetValue(0));
            try
            {
                string[] str = q.Select(c => c.ToString()).ToArray();
                string ww = string.Join("", str);

                if(Null == 0) { ww = ww.Remove(0, 1); }

                output = Convert.ToInt32(ww);
            } catch (OverflowException ex)
            {
                System.Console.WriteLine(ex.Message);
                return 0;
            }
            
            if(minus == '-') { return -output; } 
            else { return output; }
        }
    }
}