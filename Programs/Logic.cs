using System;

public class Logic
{
	public Logic()
	{
	}

	public string Stringinput(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			return str;
		}

		Console.WriteLine("No input detected, please try again.");
		Stringinput(Console.ReadLine());
		return null;
	}

	public int ConvertToInteger(string value)
	{
		if (int.TryParse(value, out int intValue))
		{
			return intValue;
		}

		Console.WriteLine("Input is invalid, please try again."); //"You done did messaed a-aron, try again!");
		ConvertToInteger(Console.ReadLine());
		return 0; // default to 0
	}

	public bool ConvertToBool(string str)
	{
		if (str == "1")
		{
			return true;
		}
		else if (str == "2")
		{
			return false;
		}

		Console.WriteLine("Input is invalid, please type 1 or 2");
		ConvertToBool(Console.ReadLine());
		return false;
	}
}
