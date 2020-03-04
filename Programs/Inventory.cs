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
		Car car0 = new Car();
		car0.IDNumber = 369;			car0.Make = "Ford";
		car0.Model = "F-150";			car0.Year = 2020;
		car0.PurchasePrice = 32500;		car0.Miles = 0;
		car0.SellingPrice = 36500;		car0.SoldPrice = 34500;
		car0.Color = "Black";			car0.Condition = "1";
		car0.Status = "2";				car0.IsNew = true;
		AddCar(car0);

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

		Car car3 = new Car();
		car3.IDNumber = 2290;			car3.Make = "NASA";
		car3.Model = "Atlantis";		car3.Year = 2020;
		car3.PurchasePrice = 15000000;  car3.Miles = 478000;
		car3.SellingPrice = 13600000;	car3.SoldPrice = 0;
		car3.Color = "red";				car3.Condition = "1";
		car3.Status = "2";				car3.IsNew = true;
		AddCar(car3);

		Car car4 = new Car();
		car4.IDNumber = 2291;			car4.Make = "Ford";
		car4.Model = "M4 Sherman Tank";	car4.Year = 1962;
		car4.PurchasePrice = 8000000;	car4.Miles = 4800;
		car4.SellingPrice = 13000000;	car4.SoldPrice = 0;
		car4.Color = "camo";			car4.Condition = "";
		car4.Status = "3";				car4.IsNew = false;
		AddCar(car4);

		Car car5 = new Car();
		car5.IDNumber = 2292;			car5.Make = "Tesla";
		car5.Model = "Model S";			car5.Year = 2017;
		car5.PurchasePrice = 84000;		car5.Miles = 3240;
		car5.SellingPrice = 76000;		car5.SoldPrice = 0;
		car5.Color = "white";			car5.Condition = "1";
		car5.Status = "";				car5.IsNew = true;
		AddCar(car5);

		//Template below

		/*Car car4 = new Car();
		car4.IDNumber = ;				car4.Make = "";
		car4.Model = "";				car4.Year = ;
		car4.PurchasePrice = ;			car4.Miles = ;
		car4.SellingPrice = ;			car4.SoldPrice = 0;
		car4.Color = "";				car4.Condition = "";
		car4.Status = "";				car4.IsNew = true;
		AddCar(car4);*/

	}
}