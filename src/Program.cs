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
                                            "7. Reverse Integer\n");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 7:
                        ReverseInteger reverseInteger = new ReverseInteger();
                        reverseInteger.Reverse_Integer();
                        System.Console.WriteLine(" ");
                        break;
                }
            }
        }
    }
}