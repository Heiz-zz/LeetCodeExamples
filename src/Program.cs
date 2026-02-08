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
                                            "9. Palindrome Number\n" + 
                                            "10. Regular Expression Matching\n" + 
                                            "11. Container With Most Water\n");

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
                    case 10:
                        regular_expression_matching matching = new regular_expression_matching();
                        matching.REM();
                        System.Console.WriteLine(" ");
                        break;    
                    case 11:
                        container_with_most_water container = new container_with_most_water();
                        container.CWMW();
                        System.Console.WriteLine(" ");
                        break;    
                }
            }
        }
    }
}