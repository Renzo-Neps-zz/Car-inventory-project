using System;

public class ProgramRun
{
	static void Main(string[] args)
	{
		Inventory inventory = new Inventory();
		Car car = new Car();
		Test(car);
		inventory.AddCar(car);
		bool keepgoing = true;

		/*Car car1 = new Car();
		Test1(car1);
		inventory.AddCar(car1);*/
		

		while (keepgoing)
		{
			Console.WriteLine("Car Inventory Menu");
			Console.WriteLine();
			Console.WriteLine("1) Search car");
			Console.WriteLine("2) Display all cars");
			Console.WriteLine("3) Add car");
			Console.WriteLine("4) Exit");

			int input = Convert.ToInt32(Console.ReadLine());

			while (input > 4)
			{
				Console.WriteLine("Please input a number between 1-4");
				Console.ReadLine();
				input = Convert.ToInt32(Console.ReadLine());
			}

			Console.Clear();

			if (input == 1)
			{
				Console.WriteLine("Please type in ID # of car");
				int value = Convert.ToInt32(Console.ReadLine());
				inventory.Display(inventory.SearchCar(value));
				Console.WriteLine();
				Console.ReadLine();
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
				Console.WriteLine("Please type the model of the car");
				c.Model = Console.ReadLine();
				Console.WriteLine("Please type the year of the car");
				c.Year = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please type the purchase price of the car");
				c.PurchasePrice = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please type the milage of the car");
				c.Miles = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please type the selling price of the car");
				c.SellingPrice = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please type the sold price of the car");
				c.SoldPrice = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please type the color of the car");
				c.Color = Console.ReadLine();

				inventory.AddCar(c);
				Console.WriteLine();
				Console.WriteLine("Car added");
				Console.ReadLine();
			}
			else
			{
				keepgoing = false;
				Environment.Exit(0);
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


	/*private static void Test1(Car car1)
	{
		car1.IDNumber = 1243;
		car1.Make = "Honda";
		car1.Model = "Civic";
		car1.Year = 2010;
		car1.PurchasePrice = 10000;
		car1.Miles = 50000;
		car1.SellingPrice = 8765;
		car1.SoldPrice = 8565;
		car1.Color = "Blue";
	}*/
}