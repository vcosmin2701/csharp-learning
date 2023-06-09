using System.Security.Cryptography;

namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			int age = 6;
			bool canDrive = age >= 16 ? true : false;
			Console.WriteLine(canDrive);

			switch(age){
				case 1:
				case 2:
					Console.WriteLine("Go to day care..");
					break;
				case 3:
				case 4:
					Console.WriteLine("Go to preschool");
					break;
				default:
					Console.WriteLine("Life school");
					break;
			}

			string name2 = "Cosmin";
			string name3 = "Cosmin";
			if (name2.Equals(name3, StringComparison.Ordinal))
			{
				Console.WriteLine("Names are equal");
			}
		}
	}
}
