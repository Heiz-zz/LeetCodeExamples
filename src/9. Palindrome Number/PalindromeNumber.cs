using System;
using System.Threading;

namespace LeetCode_Examples
{
    class PalindromeNumber
    {
        public void PN()
        {
            PalindromeNumber palindrome = new PalindromeNumber();

            string? input = Console.ReadLine();
            if(!string.IsNullOrEmpty(input))
            {
                bool result = palindrome.PNLogic(input);
                switch (result)
                {
                    case true:
                        System.Console.WriteLine("true");
                        break;
                    case false:
                        System.Console.WriteLine("false");    
                        break;
                }
            }
            Thread.Sleep(2000);
        }

        private bool PNLogic(string input)
        {
            char[] input_chars = input.ToArray();
            int index = 0;
            List<char> output = new List<char>();

            while(index < input_chars.Length)
            {
                if(input_chars[index] == '-')
                {
                    return false;
                }
                index++;
            }

            foreach(char i in input_chars)
            {
                output.Insert(0, i);
            }

            string output_String = new string(output.ToArray());

            if(input == output_String) { return true; }
            else { return false; }
        }
    }
}