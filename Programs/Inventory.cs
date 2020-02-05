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

	public void EditInventory(Car car)
	{

	}

	public void RemoveCar(Car car)
	{

	}

	public void Display(Car car)
    {
		Console.WriteLine("ID #: " + car.IDNumber);
				
		Console.WriteLine("{0} {1} {2} ",
		car.Year,
		car.Make,
		car.Model);
		Console.WriteLine();
		Console.WriteLine("Status:" + car.Status(1));

		Console.WriteLine("Condition: {0} {1}",
		car.New(false), car.Condition(3));
		Console.WriteLine("Miles: " + car.Miles);
		Console.WriteLine("Color: " + car.Color);
	}

	public void DisplayAll()
	{
		foreach (Car car in CarInventory)
		{
			Display(car);
		}
	}
}