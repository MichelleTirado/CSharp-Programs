using System;

/// <summary>
///  Program description:
///  Program that displays by console numbers from 1 to 100 (both included), substituting the following:
///  * Multiples of 3 for the word "fizz"
///  * Multiples of 5 for the word "buzz"
///  * Multiples of 3 and 5 at the same time for the word "fizzbuzz"               
/// </summary>
public class FizzBuzz
{
    public static void Run()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}