using System;

public class ProgramRun
{
	static void Main(string[] args)
	{
		Inventory inventory = new Inventory();
		Car car = new Car();
		Test(car);
		inventory.AddCar(car);
		//inventory.DisplayAll();
		//Console.ReadLine();
		bool keepgoing = true;

		while (keepgoing)
		{
			Console.WriteLine("Car Inventory Menu");
			Console.WriteLine();
			Console.WriteLine("1) Display car");
			Console.WriteLine("2) Display all cars");
			Console.WriteLine("3) Add car");
			Console.WriteLine("4) Exit");
			Console.ReadLine();

			int input = Convert.ToInt32(Console.ReadLine());

			while (input < 5)
			{
				Console.WriteLine("Please input a number between 1-4");
				Console.ReadLine();
				input = Convert.ToInt32(Console.ReadLine());
			}

			Console.Clear();

			if (input == 1)
			{
				/*Console.WriteLine("What car do you want to display?");
				Console.WriteLine("Please type a number between 0 to " + Inventory.InventoryLength());
				Display(console)*/
			}
			else if (input == 2)
			{
				Console.WriteLine("Displaying all cars");
				inventory.DisplayAll();
			}
			else if (input == 3)
			{
				Console.WriteLine("Add a new car");
				Console.WriteLine();
				Car c = new Car();
				Console.WriteLine("Please type an ID number for the car");
				c.IDNumber = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please type the car manufacturer");
				c.Make = Console.ReadLine();

				c.Model = Console.ReadLine();
				c.Year = Convert.ToInt32(Console.ReadLine());
				c.PurchasePrice = Convert.ToInt32(Console.ReadLine());
				c.Miles = Convert.ToInt32(Console.ReadLine());
				c.SellingPrice = Convert.ToInt32(Console.ReadLine());
				c.SoldPrice = Convert.ToInt32(Console.ReadLine());
				c.Color = Console.ReadLine();
			}
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
