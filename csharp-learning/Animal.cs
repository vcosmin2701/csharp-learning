using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_learning
{
	class Animal
	{
		private string name;
		private string sound;
		public static int numberOfAnimals = 0;

		public const string SHELTER = "Cosmo's farm";
		public readonly int idNum;

		public Animal():this("No name", "No Sound") {  }

		public Animal(string name) : this(name, "No Sound") { }

		public Animal(string name, string sound)
		{
			SetName(name);
			Sound = sound;
			NumOfAnimals = 1;
			Random rand = new Random();
			idNum = rand.Next(1, 214748640);
		}

		public void MakeSound()
		{
			Console.WriteLine($"{name} says {sound}");
		}

		public static int GetNumAnimals()
		{
			return numberOfAnimals;
		}

		public void SetName(string name)
		{
			if (!name.Any(char.IsDigit))
			{
				this.name = name;
			}
			else
			{
				this.name = "No name";
				Console.WriteLine("Invalid input name(can't contain digits");
			}
		}

		public string GetName()
		{
			return name;
		}

		public string Sound
		{
			get { return sound; }
			set
			{
				if(value.Length > 10)
				{
					sound = "No sound";
					Console.WriteLine("Sound is too long");
				}
				else
				{
					sound = value;
				}
			}
		}

		public string Owner { get; set; } = "No Owner";

		public static int NumOfAnimals
		{
			get { return numberOfAnimals;  } 
			set { numberOfAnimals += value; }

		}
	}
}
