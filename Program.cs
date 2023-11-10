namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze FizzBuzz.");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Podaj liczę całkowitą i naciśnij Enter.");
                var userData = FizzBuzz.CheckUserData();
                FizzBuzz fizzBuzz = new();

                fizzBuzz.CheckNumber(userData);
                Console.WriteLine(fizzBuzz.CheckNumber(userData));

                var value = "y";

                while (value == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Czy chcesz kontynuować? Y/N");
                    value = Console.ReadLine();
                    if (value?.ToLower() == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(0);
                    }

                    else if (value?.ToLower() == "y")
                        break;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Wprowadziłeś niewłaściwą wartość {value}\nWprowadź Y aby kontynuować lub N by zakończyć");
                        value = "y";
                    }
                }
            }

        }
    }
}