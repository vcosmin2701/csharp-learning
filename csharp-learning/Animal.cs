using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_learning
{
	class Animal
	{
		public string name;
		public string sound;
		static int numberOfAnimals = 0;

		public Animal()
		{
			name = "No Name";
			sound = "No Sound";
			numberOfAnimals++;
		}

		public Animal(string name = "No name")
		{
			this.name = name;
			this.sound = "No sound";
			numberOfAnimals++;
		}

		public Animal(string name = "No Name", string sound = "No Sound")
		{
			this.name = name;
			this.sound = sound;
			numberOfAnimals++;
		}

		public void MakeSound()
		{
			Console.WriteLine($"{name} says {sound}");
		}

		public static int GetNumAnimals()
		{
			return numberOfAnimals;
		}
	}
}
