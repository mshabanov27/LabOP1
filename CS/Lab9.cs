using System;
using System.Text.RegularExpressions;

namespace Lab9
{
    class Lab9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your message: ");
            string yourMessage = Console.ReadLine();

            Console.Write("Enter the character: ");
            char yourCharacter = char.Parse(Console.ReadLine());

            Console.WriteLine(numReplacer(yourMessage, yourCharacter));
        }

        static string numReplacer(string message, char character)
        {
            Regex regex = new Regex(@"\d");

            string replaced = regex.Replace(message, Convert.ToString(character));

            return replaced;
        }
    }
}
