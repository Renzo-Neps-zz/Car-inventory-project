using System;
using System.Collections;
using System.Collections.Generic;

public class Inventory
{
	List<Car> CarInventory;

	/**
	 * Search "filtering"
	 * Details "list"
	 * Add, edit, rename (status)
	 */
	public Inventory()
	{
		CarInventory = new List<Car>();
	}

	public int InventoryLength()
	{
		return CarInventory.Count;
	}

	public void AddCar(Car car)
	{
		CarInventory.Add(car);
	}

	public string StringEditMethod(string str, string word)
	{
		Console.WriteLine($"Enter car {word}"); 
		Console.WriteLine($"Currenlty its {str}");
		string change = Console.ReadLine();

		if (string.IsNullOrEmpty(change))
		{
			change = str;
		}
		return change;
	}

	public int IntEditMethod(int x, string word)
	{
		Console.WriteLine($"Enter car {word}"); 
		Console.WriteLine($"Currently its {x}");
		int change = Convert.ToInt32(Console.ReadLine());

		if (string.IsNullOrEmpty(change.ToString()))
		{
			change = x;
		}
		return change;
	}

	public void RemoveCar(Car car)
	{

	}


	public Car SearchCar(int IDinput)
	{
		foreach (Car c in CarInventory)
		{
			if (IDinput == c.IDNumber)
			{
				return c;
			}
		}
		return null;
	}

	public void Display(Car car)
    {
		Console.WriteLine("ID #: " + car.IDNumber);
				
		Console.WriteLine("{0} {1} {2} ",
		car.Year,
		car.Make,
		car.Model);
		Console.WriteLine();
		//Console.WriteLine("Status:" + car.Status(1));

		/*Console.WriteLine("Condition: {0} {1}",
		car.New(false), car.Condition(3));*/
		Console.WriteLine("Miles: " + car.Miles);
		Console.WriteLine("Color: " + car.Color);
	}

	public void DisplayAll()
	{
		foreach (Car car in CarInventory)
		{
			Display(car);
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}