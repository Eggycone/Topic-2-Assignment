using System.Security.Cryptography.X509Certificates;

namespace Topic_2_Assignment
{
    internal class Program;
    internal class Math
    {
        static void Main(string[] args)
        {   // #2
            Console.WriteLine("Birth Year");
            Console.WriteLine(2025 - 16);
            Console.WriteLine("");
            // #3
            Console.WriteLine("Average of 14, 15, and 16");
            Console.WriteLine((14 + 15 + 16) / 3);
            Console.WriteLine("");
            // #4
            Console.WriteLine("Average of 14, 15, 16, and 17");
            Console.WriteLine((14.0 + 15.0 + 16.0 + 17.0) / 4);
            Console.WriteLine("");
            // #5
            Console.WriteLine("Approximated Pi");
            Console.WriteLine(3.14 * (3 * 3));
            Console.WriteLine("");
            Console.WriteLine("Actual Pi");
            Console.WriteLine(float.Pi * (3 * 3));
            Console.WriteLine("");
            Console.WriteLine("Actual Pi, Rounded to 1 decimal point");
            Console.WriteLine(float.Round((float.Pi * (3 * 3)), 1));
            Console.WriteLine("");
            // #6
            Console.WriteLine("C# knows to add using the + operator when it is used outside of double quotes and has numbers on both sides.");
            Console.ReadLine();

        }
    }
}
