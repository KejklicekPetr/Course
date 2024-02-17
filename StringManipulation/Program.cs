namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iq = -5;
            string ability = "Skill issue";
            string pet = "cat";

            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hi I have a " + ability + " and my IQ is: " + iq + ". I also have a " + pet + ".");

            Console.WriteLine("String Formatting");
            Console.WriteLine("Hi I have a {0} and my IQ is {1}. I also have a {2}.", ability, iq, pet);

            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hi I have a {ability} and my IQ is {iq}. I also have a {pet}");

            Console.WriteLine("Verbatim String");
            Console.WriteLine(@"Hi I have a {0} and my IQ is {1}.
I also have a {2}.", ability, iq, pet);
            Console.WriteLine(@"C:\Users\Admin\Downloads\");
        }
    }
}
