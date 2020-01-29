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

	public void EditInventory()
	{

	}

	public void RemoveCar()
	{

	}

	public void display()
    {
		Console.WriteLine("ID #: ");
		Console.WriteLine();
    }
}
