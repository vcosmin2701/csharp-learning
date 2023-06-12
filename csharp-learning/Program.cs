using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			DateTime acDate = new DateTime(2022, 4, 17);
			Console.WriteLine($"Day of the week: {acDate.DayOfWeek}");

			acDate = acDate.AddDays(1);
			acDate = acDate.AddMonths(1);
			acDate = acDate.AddYears(1);

			Console.WriteLine($"New date: {acDate.Date}");

			TimeSpan lunchTime = new TimeSpan(12, 30, 0);
			lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));

			Console.WriteLine($"New time: {lunchTime}");

		}
	}
}
