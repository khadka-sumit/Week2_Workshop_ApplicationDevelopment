public class Program
{
	public static void Main()
	{
		DateTime birthdate = new DateTime(2005, 6, 15); // Use your birthdate
		DateTime currentDate = DateTime.Now;

		TimeSpan difference = currentDate - birthdate;
		int age = (int)(difference.TotalDays / 365.25);

		Console.WriteLine("Birthdate: " + birthdate.ToShortDateString());
		Console.WriteLine("Current date: " + currentDate);
		Console.WriteLine("Age in years: " + age);

		DateTime newDate = birthdate.AddDays(10);
		Console.WriteLine("Birthdate + 10 days: " + newDate.ToShortDateString());
	}
}