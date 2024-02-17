namespace ChallengeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "sqrt(-1)";
            string friend2 = "Dino";
            string friend3 = "my imaginary friend 2";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }
        static void GreetFriend(string name)
        {
            Console.WriteLine("Hi " + name + ", my friend!");
        }
    }
}
