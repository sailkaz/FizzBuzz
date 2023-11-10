using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        public static int CheckUserData()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wprowadzona wartość nie jest liczbą całkowitą\nSpróbuj jeszcze raz.");
                    continue;
                }
                return userNumber;
            }
        }

        public string CheckNumber(int userNumber)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (userNumber % 3 == 0 && userNumber % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (userNumber % 5 == 0)
            {
                return "Buzz";
            }
            if (userNumber % 3 == 0)
            {
                return "Fizz";
            }
            else
                return userNumber.ToString();
        }
    }
    
}



