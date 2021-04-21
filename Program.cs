using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int num = 5;
        int counter = 0;
        int counter2 = 0;

            while (counter < num) {
                counter2 = counter;

                while (counter2 < num) {
                    Console.Write("x");
                    counter2++;
                }
                Console.WriteLine();
                counter++;
            }


        }
    }
}
