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
			Rectangle rect1;
			rect1.length = 200;
			rect1.width = 50;
			Console.WriteLine($"Area of rect1: {rect1.Area()}");
			Rectangle rect2 = new Rectangle(100, 40);
			rect2 = rect1;
			rect1.length = 33;
			Console.WriteLine($"Rect2.length: {rect2.length}");


			Animal fox = new Animal()
			{
				name = "Red",
				sound = "Rwaaa"
			};

			Console.WriteLine($"number of animals: #{Animal.GetNumAnimals()}");
			Console.WriteLine($"Area of Rectangle: {ShapeMath.GetArea("rectangle", 5, 6)}");

			int? randNum = null;
			if (randNum == null)
			{
				Console.WriteLine("randNum is null");
			}

			if (!randNum.HasValue)
			{
				Console.WriteLine("randNum is null");
			}

		}
		struct Rectangle
		{
			public double length;
			public double width;

			public Rectangle(double l = 1, double w = 1)
			{
				length = l;
				width = w;
			}

			public double Area()
			{
				return length * width;
			}
		}
	}
}
