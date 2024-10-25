namespace Common_Divisor_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the common divisor app!");

            String choice;
            do
            {
                Console.Write("Enter first number: ");
                int entryOne = int.Parse(Console.ReadLine());  
                Console.Write("Enter second number: ");
                int entryTwo = int.Parse(Console.ReadLine());

                while (entryTwo != 0) 
                {
                    var oldEntryTwo = entryTwo;
                    entryTwo = entryOne % entryTwo;
                    entryOne = oldEntryTwo;
                }
                Console.WriteLine($"Greatest common divisor: {entryOne}");
                Console.Write("Want to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
