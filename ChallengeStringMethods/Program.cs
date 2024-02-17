namespace ChallengeStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Hello user. Please enter your name and press enter: ");
            name = Console.ReadLine();
            Console.WriteLine($"Your name is: {name}.");
            Console.WriteLine($"Your name in uppercase is: {name.ToUpper()}.");
            Console.WriteLine($"Your name in lowercase is: {name.ToLower()}.");
            Console.WriteLine($"Your name wo whitespace: {name.Replace(" ", "")}.");
            Console.WriteLine($"Your name wo your first character: {name.Substring(1)}.");
        }
    }
}
