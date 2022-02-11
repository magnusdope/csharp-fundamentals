using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array can look like this, but it't not optimal. 
            // We have to declare how many elements we want to have in -
            // our array and assign the values to the each index numbers

            int[] numbers = new int[5];
            
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();

            // Here is a better version of using array, we dont need to assign any -
            // elements sizes or assigning any values to the indexs.


            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();

            // We create an array with strings, and display it using for loop.

            string[] names = new string[] { "Eddie", "Alex", "Micheal" };
            
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            
            Console.ReadLine();
            
            // Easier way to display the items inside the array.
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.ReadLine();
            
            // Down below is shown how to reverse a string using an array.

            string zig = "Jeg er sej.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
        }
    }
}
