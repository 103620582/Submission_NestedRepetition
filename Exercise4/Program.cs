using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("Please enter how many x's");
        string num1 = Console.ReadLine();
    
        int num = int.Parse(num1);
        int counter1 = 0;
        
        while (counter1 < num) {
        int counter2 = 0;

            while (counter2++ < counter1)
            Console.Write("x");
            Console.WriteLine();
            counter1++;
        
        } 

        Console.WriteLine("Cheerz, cya!");

        }
    }
}
