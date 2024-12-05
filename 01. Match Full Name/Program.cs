using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            Regex regex = new Regex(patern);

           MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }

        }
    }
}
