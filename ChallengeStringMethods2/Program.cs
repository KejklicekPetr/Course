namespace ChallengeStringMethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string input = Console.ReadLine();
            Console.Write("What character should I search for?: ");
            char search = Console.ReadKey().KeyChar;
            int index = input.IndexOf(search);
            Console.WriteLine($"\nThe first occurence is at index: {index}.");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Your full name is: {fullName}");
            Console.ReadKey();
        }
    }
}
