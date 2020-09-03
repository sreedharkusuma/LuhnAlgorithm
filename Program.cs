using System;

namespace LuhnAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // string cardno = "5419190102395251";
            Console.WriteLine("Enter Number : ");
            string cardno = Console.ReadLine();

            Console.WriteLine((CheckLuhnAlgorithm(cardno)) ? "given number passed on luhn algorithm" : "given number failed on luhn algorithm");
            Console.ReadKey();
        }

        static bool CheckLuhnAlgorithm(string luhnnumber)
        {
            int sum = 0;
            bool isEven = false;
            for (int i = luhnnumber.Length - 1; i >= 0; i--)
            {
                int number = int.Parse(luhnnumber[i].ToString());
                sum += (
                        isEven
                    ) ? (
                        (number * 2) > 9
                    ) ? ((number * 2) % 10) + 1 : (number * 2) : number;

                isEven = !isEven;
            }
            return (sum % 10 == 0);
        }
    }
}
