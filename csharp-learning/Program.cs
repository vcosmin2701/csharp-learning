using csharp_learning;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			Animal cat = new Animal();
			cat.SetName("Marty");
			cat.Sound = "Meow";
			Console.WriteLine($"The cat is named {cat.GetName()} and says {cat.Sound}");
			cat.Owner = "Cosmo";
			Console.WriteLine($"{cat.GetName()} owner is {cat.Owner}");
			Console.WriteLine($"{cat.GetName()} shelter id is {cat.idNum}");
			Console.WriteLine($"# number of animals is {Animal.numberOfAnimals}");
		}
	}
}
