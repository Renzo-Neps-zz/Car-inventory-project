using System;

public class ProgramRun
{
	static void Main(string[] args)
	{
		Inventory inventory = new Inventory();
		Car car1 = new Car();
		Test(car1);
		inventory.AddCar(car1);
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
