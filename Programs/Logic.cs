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

		return null; // default to 0
	}
}
