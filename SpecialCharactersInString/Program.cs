namespace SpecialCharactersInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "this is a string with a \"quote\" in it";
            string s2 = "this is a string with a \\backslash\\ in it";
            string s3 = "this is a string with a \nnewline in it";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
