namespace StringTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "blue";
            string msg = "My name is " + myName;
            string caps = msg.ToUpper();
            string lower = msg.ToLower();
            Console.WriteLine(msg);
            Console.WriteLine(caps);
            Console.WriteLine(lower);
            Console.ReadKey();
        }
    }
}
