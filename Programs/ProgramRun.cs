using System;

public class ProgramRun
{
	static void Main(string[] args)
	{
		Inventory inventory = new Inventory();
		Car car1 = new Car();
		Test(car1);
		inventory.AddCar(car1);
		inventory.DisplayAll();
		Console.ReadLine();

		Console.WriteLine("Car Inventory Menu");
		Console.WriteLine();
		Console.WriteLine("1) Display car");
		Console.WriteLine("2) Display all cars");
		Console.WriteLine("3) Add car");
		Console.WriteLine("4) Exit");
		Console.ReadLine();
		
		string input = Console.ReadLine();
		
		while (input < 5)
		{
			input = Console.ReadLine();
		}
	}

	private static void Test(Car car)
	{
		car.IDNumber = 369;
		car.Make = "Ford";
		car.Model = "F-150";
		car.Year = 2020;
		car.PurchasePrice = 32500;
		car.Miles = 0;
		car.SellingPrice = 36500;
		car.SoldPrice = 34500;
		car.Color = "Black";
	}
}
