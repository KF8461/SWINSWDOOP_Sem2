using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Fib1 = 1;
            decimal Fib2 = 1;
            decimal Fib3 = 0;
            int counter = 3;
            decimal Fact = 0;
            bool exit = false;
            do
            {
                Fact = 1;
                for (int i = 1; i<= counter; i++)
                {
                    Fact = Fact * i;
                }
                Console.WriteLine(Fact);
                do
                {
                    Fib3 = Fib1 + Fib2;
                    Fib1 = Fib2;
                    Fib2 = Fib3;
                } while (Fib3 < Fact);
                if (Fib3 == Fact)
                {
                    exit = true;
                }
                Console.WriteLine(counter);
                Console.WriteLine(Fact);
                counter++;
            } while (exit==false);
            Console.WriteLine("Found It");
            Console.WriteLine(Fib3);
            Console.WriteLine(counter);
            Console.WriteLine(Fact);
            Console.ReadLine();
        }  
    }
}
