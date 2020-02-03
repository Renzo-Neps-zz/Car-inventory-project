using System;
using System.Collections;
using System.Collections.Generic;

public class Inventory
{
	List<Car> CarInventory = new List<Car>();

	/**
	 * Search "filtering"
	 * Details "list"
	 * Add, edit, rename (status)
	 */
	public Inventory()
	{

	}

	public void AddCar(Car car)
	{
		CarInventory.Add(car);
	}

	public void EditInventory(Car X)
	{

	}

	public void RemoveCar(Car X)
	{

	}

	public void Display(Car x)
    {
		Console.WriteLine("ID #: ");
		Console.WriteLine();
    }

	public void DisplayAll()
	{
		foreach (Car x in CarInventory)
		{
			Display(x);
		}
	}
}
