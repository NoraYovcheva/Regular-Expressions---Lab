using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";

            Regex regex = new Regex(patern);
            MatchCollection matches = regex.Matches(input);


            Console.Write(string.Join(", ", matches));

        }
    }
}
