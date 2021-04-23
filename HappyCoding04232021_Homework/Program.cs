using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace HappyCoding04232021_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> matchedStrings = new List<string>();
            var input = File.ReadAllText("C:/Users/SamuelS/Downloads/wiki-http-status-codes.txt");

            Regex regex = new Regex(@"\b[0-9]{3}\b");
            foreach (Match match in regex.Matches(input))
            {
                if (!matchedStrings.Contains(match.Value))
                {
                    matchedStrings.Add(match.Value);
                }
            }

            matchedStrings.Sort();
            matchedStrings.ForEach(a =>
            {
                Console.WriteLine(a);
            });

            Console.ReadKey();
        }
    }
}
