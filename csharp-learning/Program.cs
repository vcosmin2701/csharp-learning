﻿namespace Program
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Currency : {0:c}", 23.455);
			Console.WriteLine("Pad with 0s : {0:d4}", 23);
			Console.WriteLine("3 decimals : {0:f3}", 23.45555);
			Console.WriteLine("Commas : {0:n4}", 23.455);
		}
	}
}
