﻿using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patern = @"(?<day>\d{2})([.|\-|\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            Regex regex = new Regex(patern);

            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
