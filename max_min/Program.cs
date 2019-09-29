using System;

namespace max_min
{
    class Program
    {
        static void Main(string[] args)
        {
            // to know max and min value of char and int ...etc
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            int mycharvalue = 'g';

            Console.WriteLine($"min char = {charMin} max char = {charMax} my char value= {mycharvalue}");

            int intmin = int.MinValue;
            int intmax = int.MaxValue;

            Console.WriteLine($"min value = {intmin} max value = {intmax}");

        }
    }
}
