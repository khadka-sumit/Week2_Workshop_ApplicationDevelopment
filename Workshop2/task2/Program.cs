using task2;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("PI =" +Circle.PI);
		//PI in circle class is declared as const therefore when i try to modify it then it shows error
		Circle.PI = 3.1455;
	}
}