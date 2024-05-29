/*
15. Write a C# program that removes a specified character from a non-empty string using the index of a character.
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource
*/

using System;
using System.Collections.Generic;

public class Ex15{
    static void Main(string[] args)
    {

        System.Console.WriteLine(remove_char("w3resource", 1));
        System.Console.WriteLine(remove_char("w3resource", 9));
        System.Console.WriteLine(remove_char("w3resource", 0));

    }


        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }




