using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz.Run();
            //Anagram.Run("Amor", "roma");

            //Fibonacci Sequence
            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{Fibonacci.FibonacciSequence(i)}" + ",");
            }
        }
    }
}
