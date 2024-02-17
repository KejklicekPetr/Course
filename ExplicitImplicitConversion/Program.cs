namespace ExplicitImplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 69420;
            long bigNum = num; // Implicit conversion

            float myFloat = 69.42f;
            int myInt = (int)myFloat; // Explicit conversion
            double myDouble = myFloat; // Implicit conversion

            string myString = myDouble.ToString(); // Explicit conversion
            string myString2 = myInt.ToString(); // Explicit conversion

            bool sunShining = true;
            string myBoolString = sunShining.ToString(); // Explicit conversion

            Console.WriteLine("Explicit is just casting. (int); (float); (double); .ToString()");
            Console.WriteLine("Implicit is just auto conversion, wo data loss. Int => Long; Float => Double");
        }
    }
}
