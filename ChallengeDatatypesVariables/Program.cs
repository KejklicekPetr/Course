namespace ChallengeDatatypesVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
			byte myByte = 255;
			sbyte mySByte = -128;
			int myInt = 2147483647;
			uint myUInt = 4294967295;
			short myShort = 32767;
			ushort myUShort = 65535;
			long myLong = 9223372036854775807;
			ulong myULong = 18446744073709551615;
			float myFloat = 3.402823e38f;
			double myDouble = 1.79769313486231e308;
			char myChar = 'A';
			bool myBool = true;
            decimal myDecimal = 7.9e28m;
            string myString = "I control text";
			string myString2 = "69420";
			int myInt2 = int.Parse(myString2);
			Console.WriteLine("Byte: " + myByte);				
			Console.WriteLine("SByte: " + mySByte);				
			Console.WriteLine("Int32: " + myInt);
			Console.WriteLine("UInt32: " + myUInt);
			Console.WriteLine("Int16/Short: " + myShort);
			Console.WriteLine("UInt16/UShort: "+ myUShort);
			Console.WriteLine("Int64/Long: " + myLong);
			Console.WriteLine("UInt64/ULong: " + myULong);
			Console.WriteLine("Float: " + myFloat);
			Console.WriteLine("Double: " + myDouble);
			Console.WriteLine("Char: '" + myChar + "'");
			Console.WriteLine("Bool: " + myBool);
            Console.WriteLine("Decimal: " + myDecimal);
            Console.WriteLine("String: " + myString);
			Console.WriteLine("String parsed to Int32: " + myInt2);
        }	
    }	
}
