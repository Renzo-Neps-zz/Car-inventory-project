using System;

public class ProgramRun
{
	static void Main(string[] args)
	{
		Inventory inventory = new Inventory();
		
		Car car = new Car();
		car.IDNumber = 369;
		car.Make = "Ford";
		car.Model = "F-150";
		car.Year = 2020;
		car.PurchasePrice = 32500;
		car.Miles = 0;
		car.SellingPrice = 36500;
		car.SoldPrice = 34500;
		car.Color = "Black";

		Car car1 = new Car();
		car1.IDNumber = 1243;
		car1.Make = "Honda";
		car1.Model = "Civic";
		car1.Year = 2010;
		car1.PurchasePrice = 10000;
		car1.Miles = 50000;
		car1.SellingPrice = 8765;
		car1.SoldPrice = 8565;
		car1.Color = "Blue";


		Car car2 = new Car();
		car2.IDNumber = 2288;
		car2.Make = "Hyundai";
		car2.Model = "Tucson";
		car2.Year = 2018;
		car2.PurchasePrice = 19000;
		car2.Miles = 10000;
		car2.SellingPrice = 17500;
		car2.SoldPrice = 17000;
		car2.Color = "Burgandy";

		inventory.AddCar(car);
		inventory.AddCar(car1);
		inventory.AddCar(car2);
		bool keepgoing = true;


		while (keepgoing)
		{
			Console.WriteLine("Car Inventory Menu");
			Console.WriteLine();
			Console.WriteLine("1) Remove/Edit/Display car");
			Console.WriteLine("2) Display all cars");
			Console.WriteLine("3) Add car");
			Console.WriteLine("4) Exit");

			int? input = inventory.ConvertToInteger(Console.ReadLine());

			while(input.HasValue == false || (input > 4 || input < 1))
			{
				Console.WriteLine("You done did messaed a-aron, try again!");
				input = inventory.ConvertToInteger(Console.ReadLine());
			}

			Console.Clear();

			if (input == 1)
			{
				Console.WriteLine("Please type in ID # of car");
				int carId = Convert.ToInt32(Console.ReadLine());
				Car foundCar = inventory.SearchCar(carId);

				Console.WriteLine("Please input a number between 1-3");
				Console.WriteLine("1) Remove car");
				Console.WriteLine("2) Edit car");
				Console.WriteLine("3) Display car");
				Console.WriteLine("4) Exit");
				
				int input2 = Convert.ToInt32(Console.ReadLine());
				while(input2 > 4 || input2 < 1)
				{
					Console.WriteLine("Please input a number between 1-4");
					input2 = Convert.ToInt32(Console.ReadLine());
				}
				
				if (input2 == 1)
				{

				}
				else if (input2 == 2)
				{
					Console.Clear();
					foundCar.Make = inventory.StringEditMethod(car.Make, "make");
					Console.WriteLine(car.Make);
					foundCar.Model = inventory.StringEditMethod(car.Model, "model");
					Console.WriteLine(car.Model);
					foundCar.Year = inventory.IntEditMethod(car.Year, "year");
					Console.WriteLine(car.Year);
					foundCar.PurchasePrice = inventory.IntEditMethod(car.PurchasePrice, "purchase price");
					Console.WriteLine(car.PurchasePrice);
					foundCar.Miles = inventory.IntEditMethod(car.Miles, "miles");
					Console.WriteLine(car.Miles);
					foundCar.SellingPrice = inventory.IntEditMethod(car.SellingPrice, "selling price");
					Console.WriteLine(car.SellingPrice);
					foundCar.SoldPrice = inventory.IntEditMethod(car.SoldPrice, "sold price");
					Console.WriteLine(car.SoldPrice);
					foundCar.Color = inventory.StringEditMethod(car.Color, "color");
					Console.WriteLine(car.Color);
					inventory.UpdateCar(foundCar);
				}
				else if (input2 == 3)
				{
					inventory.Display(inventory.SearchCar(carId));
					Console.WriteLine();
					Console.ReadLine();
				}
				else
				{

				}
			}
			else if (input == 2)
			{
				Console.Clear();
				Console.WriteLine("Displaying all cars");
				inventory.DisplayAll();
			}
			else if (input == 3)
			{
				Console.Clear();
				Console.WriteLine("Add a new car");
				Console.WriteLine();
				Car c = new Car();

				// Get ID Number
				Console.WriteLine("Please type an ID number for the car");
				int? idNumber = inventory.ConvertToInteger(Console.ReadLine());
				while (idNumber == null || inventory.SearchCar((int)idNumber) != null) {
					Console.WriteLine("Id is invalid or already exsits. Try again");
					idNumber = inventory.ConvertToInteger(Console.ReadLine());
				}

				c.IDNumber = (int)idNumber;

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
}