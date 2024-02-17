namespace IntParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int myInt = int.Parse(myString);
            int mySecondInt = int.Parse(mySecondString);
            int result = myInt + mySecondInt;
            string badResult = myString + mySecondString;
            Console.WriteLine(result);
            Console.WriteLine("Bad: " + badResult);
        }
    }
}
