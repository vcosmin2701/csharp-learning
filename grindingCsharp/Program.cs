namespace grindingCsharp
{
	class Program
	{
		static void Main(string[] args)
		{
			IElectronicDevice TV = TVRemote.GetDevice();
			PowerButton powButton = new PowerButton(TV);
			powButton.Execute();
			powButton.Undo();
		}
	}
}