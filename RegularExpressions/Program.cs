using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"([*@])([A-Z][a-z]{2,})\1: \[(\w)]\|\[(\w)]\|\[(\w)]\|$"); 

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {

                    string title = match.Groups[2].Value;
                    char firstLetter = char.Parse(match.Groups[3].Value);
                    char secondLetter = char.Parse(match.Groups[4].Value);
                    char thirdLetter = char.Parse(match.Groups[5].Value);

                    Console.WriteLine($"{title}: {(int)firstLetter} {(int)secondLetter} {(int)thirdLetter}");

                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }

            Console.WriteLine();
        }
    }
}