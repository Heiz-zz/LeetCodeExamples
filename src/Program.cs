using System;

namespace LeetCode_Examples
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                System.Console.WriteLine("Select:\n" + 
                                            "7. Reverse Integer\n" +
                                            "8. String to Integer (atoi)\n" + 
                                            "9. Palindrome Number\n");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 7:
                        ReverseInteger reverseInteger = new ReverseInteger();
                        reverseInteger.Reverse_Integer();
                        System.Console.WriteLine(" ");
                        break;
                    case 8:
                        StringToIntegerAtoi atoi = new StringToIntegerAtoi();
                        atoi.StringToInteger();
                        System.Console.WriteLine(" ");
                        break; 
                    case 9:
                        PalindromeNumber palindrome = new PalindromeNumber();
                        palindrome.PN();
                        System.Console.WriteLine(" ");
                        break;       
                }
            }
        }
    }
}