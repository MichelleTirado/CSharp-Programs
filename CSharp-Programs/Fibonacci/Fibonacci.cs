using System.Collections.Generic;

/// <summary>
/// Summary description for Anagram
///  Program description:
///  Write a program to print 50 first number of fibonacci sequence (starts on 0).             
/// </summary>
/// 
public class Fibonacci
{
    //Dictionary for memoization
    public static Dictionary<int, long> memo = new Dictionary<int, long>();

    //Recursive with memoization
    public static long FibonacciSequence(int n)
    {
        if(memo.ContainsKey(n)) return memo[n];
        if (n == 0) return 0;
        if (n == 1) return 1;

        //Calculate and save the result on dictionary
        memo[n] = FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
        return memo[n];
    }

}

