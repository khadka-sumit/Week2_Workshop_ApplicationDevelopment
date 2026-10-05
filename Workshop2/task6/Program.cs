public class Program
{
	public static void Main()
	{
		List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };

		fruits.Add("Orange");
		fruits.Remove("Banana");

		Console.WriteLine("Fruits:");
		foreach (string fruit in fruits)
		{
			Console.WriteLine(fruit);
		}

		Dictionary<int, string> fruitIds = new Dictionary<int, string>
		{
			{ 1, "Apple" },
			{ 2, "Mango" },
			{ 3, "Banana" }
		};

		fruitIds.Add(4, "Orange");

		Console.WriteLine("Fruit IDs and names:");
		foreach (var fruit in fruitIds)
		{
			Console.WriteLine(fruit.Key + ": " + fruit.Value);
		}
	}
}