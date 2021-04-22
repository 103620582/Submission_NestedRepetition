using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of x's.");
            string number = Console.ReadLine();

            int num1 = int.Parse(number);

            int counter = 0;
            int counter2 = 0;

            while (counter < num1) {
                counter2 = counter;

                while (counter2 < num1) {
                    Console.Write("x");
                    counter2++;
                }

                Console.WriteLine();
                counter++;
            }

            Console.WriteLine("Thanks, cya!");


        }
    }
}
