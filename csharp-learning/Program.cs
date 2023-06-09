using System.Security.Cryptography;

namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			int i = 1;
			while(i <= 10)
			{
				if(i % 2 == 0)
				{
					i++;
					continue;
				}

				if(i == 9)
				{
					break;
				}

				Console.WriteLine(i);
				i++;
			}
		}
	}
}
