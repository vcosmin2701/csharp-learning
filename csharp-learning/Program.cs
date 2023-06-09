namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();
			Console.Write("What is your name ? ");
			string name = Console.ReadLine();
			Console.WriteLine($"Hello {name}!");

		}
	}
}
