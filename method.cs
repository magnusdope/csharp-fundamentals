using System;

namespace SimpelMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name: ");
            string lastName = Console.ReadLine();

            DisplayResult(ReverseString(firstName), ReverseString(lastName));
            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messsageArray = message.ToCharArray();
            Array.Reverse(messsageArray);
            return String.Concat(messsageArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1}", reversedFirstName, reversedLastName));
        }

    }
}
