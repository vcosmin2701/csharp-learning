using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Program
{
	public class Program
	{

		static double GetSum2(double x = 1, double y = 1) {
			return x + y;
		}

		static double GetSum2(string x = "1", string y = "1")
		{
			double dblX = Convert.ToDouble(x);
			double dblY = Convert.ToDouble(y);
			return dblX + dblY;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(GetSum2(5.0, 4.5));
			Console.WriteLine(GetSum2("5.0", "4.5"));

		}
	}
}
