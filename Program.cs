using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardno = "651596271837";
            Console.WriteLine(CheckLuhnAlgorithm(cardno));
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
