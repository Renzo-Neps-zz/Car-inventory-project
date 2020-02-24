using System;

public class Logic
{
	public Logic()
	{
	}

	public int? ConvertToInteger(string value)
	{
		if (int.TryParse(value, out int intValue))
		{
			return intValue;
		}
		
		Error(); // default to 0
		return 0;
	}

	private void Error()
	{
		Console.WriteLine("Input is invalid, please try again."); //"You done did messaed a-aron, try again!");
		ConvertToInteger(Console.ReadLine());
	}
}
