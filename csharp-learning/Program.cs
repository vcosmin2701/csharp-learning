namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();

			bool canIVote = true;
			Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
			Console.WriteLine("Biggest Integer: {0}", int.MinValue);

			Console.WriteLine("Biggest Long: {0}", long.MaxValue);
			Console.WriteLine("Biggest Long: {0}", long.MinValue);

			decimal decPiVal = 3.1415926535897932384626433832M;
			decimal decBigNum = 3.00000000000000000000000000011M;
			Console.WriteLine(decPiVal + decBigNum);
		}
	}
}
