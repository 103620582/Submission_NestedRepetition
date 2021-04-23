using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

        int num = 5;
        int counter1 = 0;
        
        while (counter1 < num) {
        int counter2 = 0;
            while (counter2++ < counter1)
            Console.Write("x");
            Console.WriteLine();
            counter1++;
        
        } 


        }
    }
}
