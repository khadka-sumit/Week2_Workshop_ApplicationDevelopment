public class Program
{
	public static void Main()
	{
		byte bytevalue = 1;
		short shortvalue = 2;
		int intvalue = 42;
		long longvalue = 4;
		float floatvalue = 5;
		double doublevalue = 6;
		decimal decimalvalue = 7;
		char charvalue = 'h';
		bool boolvalue= true;
		String stringvalue = "3.14";

		String cobvertToString = intvalue.ToString();
		double convertTodoule = Convert.ToDouble(stringvalue);
		
		Console.WriteLine("Byte: " + bytevalue);
		Console.WriteLine("Short: " + shortvalue);
		Console.WriteLine("Int: " + intvalue);
		Console.WriteLine("Long: " + longvalue);
		Console.WriteLine("Float: " + floatvalue);
		Console.WriteLine("Double: " + doublevalue);
		Console.WriteLine("Decimal: " + decimalvalue);
		Console.WriteLine("Char: " + charvalue);
		Console.WriteLine("Bool: " + boolvalue);
		Console.WriteLine("String: " + stringvalue);
		Console.WriteLine("Convert to string: " + cobvertToString);
		Console.WriteLine("convert To Double: " + convertTodoule);
	}
}