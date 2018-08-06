using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Fibonacci = new List<int>();
            List<int> PrimeFib = new List<int>();
            int Fib1 = 1;
            int Fib2 = 1;
            int Fib3 = 0;
            int Counter = 0;
            bool CheckPrime = false;
            bool exit = false;
            Fibonacci.Add(Fib2);
            do
            {
                Fib3 = Fib1 + Fib2;
                Console.WriteLine(Fib3);
                Fibonacci.Add(Fib3);
                for (int i = (Fib3 - 1); i > 1; i--)
                {
                    if ((Fib3 % i) == 0)
                    {
                        CheckPrime = true;
                    }
                }
                if (CheckPrime == false)
                {
                    Counter++;
                    PrimeFib.Add(Fib3);
                }
                if (Counter == 8)
                {
                    exit = true;
                }
                Fib1 = Fib2;
                Fib2 = Fib3;
                CheckPrime = false;
            } while (exit == false);
            foreach (int s in PrimeFib)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine(PrimeFib.Sum());
            Console.ReadLine();
        }
    }
}
