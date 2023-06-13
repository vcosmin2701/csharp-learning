namespace grindingCsharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle car1 = new Vehicle("Porsche Carrera GT", 4, 208);
			if(car1 is IDrivable)
			{
				car1.Move();
				car1.Stop();
			}
			else
			{
				Console.Write("This is faulty {0}", car1.Brand);
			}
		}
	}
}