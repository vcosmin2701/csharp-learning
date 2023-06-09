namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Strings
			string randString = "This is a string";
			Console.WriteLine(randString.Length);
			Console.WriteLine(randString.Contains("is"));
			Console.WriteLine(randString.IndexOf("is"));
			Console.WriteLine(randString.Remove(10, 6));
			Console.WriteLine(randString.Insert(10, "short"));
			Console.WriteLine(randString.Replace("string", "sentence"));
			Console.WriteLine(String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("-------------------------");

			Console.WriteLine("A = 0 : {0}",
				String.Equals("A", "a", 
				StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("Pad Left : {0}",
				randString.PadLeft(20, '.'));
			Console.WriteLine("Pad Right : {0}",
				randString.PadRight(20, '.'));

			Console.WriteLine("Trim : {0}",
				randString.Trim());

			Console.WriteLine("Trim : {0}",
				randString.Trim());

			Console.WriteLine("Uppercase : {0}",
				randString.ToUpper());

			Console.WriteLine("Lowercase : {0}",
				randString.ToLower());

			string newString = string.Format("{0} saw a {1} {2} in the {3}",
				"Paul", "rabbit", "eating", "field");
			Console.WriteLine(newString);
			Console.WriteLine(@"Exactly what I've typed \n");
		}
	}
}
