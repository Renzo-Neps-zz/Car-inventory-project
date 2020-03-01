using System;
using System.Collections;
using System.Collections.Generic;

public class Inventory
{
	Logic logic;
	List<Car> CarInventory;

	/**
	 * Search "filtering"
	 * Details "list"
	 * Add, edit, rename (status)
	 */
	public Inventory()
	{
		logic = new Logic();
		CarInventory = new List<Car>();
		AddCars();
	}

	public int InventoryLength()
	{
		return CarInventory.Count;
	}

	public void AddCar(Car car)
	{
		CarInventory.Add(car);
	}

	public void RemoveCar(Car car)
	{
		CarInventory.Remove(car);
	}

	public void UpdateCar(Car car)
	{
		RemoveCar(car);
		AddCar(car);
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

	public decimal DecimalEditMethod(decimal x, string word)
	{
		Console.WriteLine($"Enter car {word}");
		Console.WriteLine($"Currently its {x}");
		decimal change = logic.ConvertToInteger(Console.ReadLine());

		if (string.IsNullOrEmpty(change.ToString()))
		{
			change = x;
		}
		return change;
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
		Console.WriteLine("Status: " + car.Status);

		Console.WriteLine("Condition: {0} {1}",
		car.IsNew ? "New" : "Used", car.Condition);
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

	private void AddCars()
	{
		Car car = new Car();
		car.IDNumber = 369;				car.Make = "Ford";
		car.Model = "F-150";			car.Year = 2020;
		car.PurchasePrice = 32500;		car.Miles = 0;
		car.SellingPrice = 36500;		car.SoldPrice = 34500;
		car.Color = "Black";			car.Condition = "1";
		car.Status = "2";				car.IsNew = true;
		AddCar(car);

		Car car1 = new Car();
		car1.IDNumber = 1243;			car1.Make = "Honda";
		car1.Model = "Civic";			car1.Year = 2010;
		car1.PurchasePrice = 10000;		car1.Miles = 50000;
		car1.SellingPrice = 8765;		car1.SoldPrice = 8565;
		car1.Color = "Blue";			car1.Condition = "4";
		car1.Status = "3";				car1.IsNew = false;
		AddCar(car1);

		Car car2 = new Car();
		car2.IDNumber = 2288;			car2.Make = "Hyundai";
		car2.Model = "Tucson";			car2.Year = 2018;
		car2.PurchasePrice = 19000;		car2.Miles = 10000;
		car2.SellingPrice = 17500;		car2.SoldPrice = 17000;
		car2.Color = "Burgandy";		car2.Condition = "5";
		car2.Status = "1";				car2.IsNew = false;
		AddCar(car2);
	}
}