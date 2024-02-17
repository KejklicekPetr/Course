namespace VariableTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num3, num4, num5;

            int num1;
            num1 = 13;

            int num2 = 23;
            num2 = 100;

            Console.WriteLine("Num1: " + num1);
            int sum = num1 + num2;
            Console.WriteLine("Num1: " + num1 + " + Num 2: " + num2 + " equals " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double d = d1 / d2;
            Console.WriteLine("d1: " + d1 + " / d2: " + d2 + " equals " + d);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float f = f1 / f2;
            Console.WriteLine("f1: " + f1 + " / f2: " + f2 + " equals " + f);

            double div = d1 / num1;
            Console.WriteLine("d1: " + d1 + " / num1: " + num1 + " equals " + div);

            Console.ReadLine();
        }
    }
}
