namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			bool boolFromString = bool.Parse("true");
			int intFromString = int.Parse("100");
			double doubleFromString = double.Parse("1.234");

			string stringVal = doubleFromString.ToString();
			Console.WriteLine(stringVal.GetType());

			double doubleNumber = 12.345;
			Console.WriteLine($"{(int)doubleNumber}");

			int intNum = 10;
			long longNum = intNum;
			
		}
	}
}
