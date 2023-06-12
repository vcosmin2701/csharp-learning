using csharp_learning;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			Animal marty = new Animal()
			{
				Name = "Marty",
				Sound = "Meoowww"
			};

			Dog roco = new Dog()
			{
				Name = "Roco",
				Sound = "Woof",
				Sound2 = "Grrrrrrr..."
			};

			roco.Sound = "Woooofff";
			marty.MakeSound();
			roco.MakeSound();

			marty.SetAnimalIDInfo(123456, "Cosmo");
			roco.SetAnimalIDInfo(4324234, "Cosmo");

			marty.GetAnimalIDInfo();
			Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
			Console.WriteLine($"Is my animal healthy : {getHealth.HealthyWeight(11, 46)}");

			Animal monkey = new Animal()
			{
				Name = "chittaaa",
				Sound = "hihihih"
			};

			Animal spot = new Dog()
			{
				Name = "Spot",
				Sound = " Woofofofofoof",
				Sound2 = "GRiidsfdsfds"
			};

			spot.MakeSound();


		}
	}
}
