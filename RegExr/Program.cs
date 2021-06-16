using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var text = Console.ReadLine();

        var patten = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)");

        MatchCollection mathe = patten.Matches(text);


        foreach (Match item in mathe)
        {
            Console.Write("{0} ", string.Join(" ", item));
        }

    }
}