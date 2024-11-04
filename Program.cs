namespace Assignment_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create a console app that asks for name, age, and address
             * assigns those things to a variable
             * and prints out each one */

            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();

            Console.WriteLine("\nWhat is your age?");
            double age = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine("\nWhat is your home address?");
            string? address = Console.ReadLine();

            Console.WriteLine($"\nOkay, so your name is {name}, you are {age} years old and you live at {address}?");
        }
    }
}