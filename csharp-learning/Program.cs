namespace Program
{
	public class Program
	{
		// ---- FUNCTIONS ---------
		static void PrintArray(int[] intArray,string mess)
		{
			foreach(int i in intArray)
			{
				Console.WriteLine($"{i} : {mess}");
			}
		}

		// ---- END OF FUNCTIONS ---------
		static void Main(string[] args)
		{
			int[] favoriteNums = new int[3];
			favoriteNums[0] = 27;
			Console.WriteLine($"fav num index 0 {favoriteNums[0]}");
			string[] customers = { "Cosmo", "Mili", "Magda", "MyShU" };
			var emplyees = new[] { "Paul", "Rick" };
			object[] randomArray = { "Cosmo", 22, 1.234 };
			for(int i = 0; i < randomArray.Length; i++)
			{
				Console.WriteLine($"Array : {i} : Value : {favoriteNums[i]}");
			}

			Console.WriteLine("--------------------");
			int[,] matrixNum = new int[2, 2] { { 0, 1 }, { 0, 2 } };
			for(int j = 0; j < matrixNum.GetLength(0); j++)
			{
				for(int k=0;k<matrixNum.GetLength(0); k++)
				{
					Console.Write($"{matrixNum[j, k]} ");
				}
				Console.WriteLine();
			}

			int[] randNums = { 1, 4, 9, 2 };
			PrintArray(randNums, "Foreach");

			Console.WriteLine("--------------------");

			Array.Sort(randNums);
			Console.WriteLine(randNums);
			Array.Reverse(randNums);
			Console.WriteLine(randNums);
			Console.WriteLine($"1 at index {Array.IndexOf(randNums, 1)}");
			randNums.SetValue(0, 1);
			int[] srcArray = { 1, 2, 3, 4 };
			int[] dstArray = new int[2];
			int startInd = 0;
			int length = 2;
			Array.Copy(srcArray, startInd, dstArray, 0, length);
			PrintArray(dstArray, "Copy");
			Array anotherArray = Array.CreateInstance(typeof(int), 10);
			srcArray.CopyTo(anotherArray, 5);
			foreach(int m in anotherArray)
			{
				Console.WriteLine($"Copy to: {m}");
			}

		}
	}
}
