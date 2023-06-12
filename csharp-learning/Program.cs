using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Program
{
	public class Program
	{

		public static void Swap(ref int num3, ref int num4)
		{
			int temp = num3;
			num3 = num4;
			num4 = temp;
		}

		static void Main(string[] args)
		{
			int num3 = 10;
			int num4 = 20;
			Console.WriteLine($"Before Swap num3 {num3} , num4 {num4}");
			Swap(ref num3, ref num4);
			Console.WriteLine($"After Swap num3 {num3} , num4 {num4}");


		}
	}
}
