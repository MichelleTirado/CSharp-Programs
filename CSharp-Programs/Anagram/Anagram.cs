using System;
using System.Linq;

/// <summary>
///  Program description:
///  Function that receive two strings and returns true or false if the word is an anagram.
///  * An anagram consists of forming a word by rearrangin all the letters of an initial word.
///  * It is NOT necessary to check if that both words exist
///  * If two words are exactly the same, they are not anagrams.              
/// </summary>
/// 

public class Anagram
{
    public static bool Run(string str1, string str2)
    {
        //If both strings are equals, then they are not anagrams
        if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Words are not anagrams");
            return false;
        }
            
        //Normalize strings: convert to lower case and give they an order
        string str1Order = new string(str1.ToLower().OrderBy(str => str).ToArray());
        string str2Order = new string(str2.ToLower().OrderBy(str => str).ToArray());

        //Return if both string are equals
        bool isAnagram = str1Order == str2Order;

        Console.WriteLine("Are the words anagrams? " + isAnagram);
        return isAnagram;
    }
}

