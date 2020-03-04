using System;

public class ProgramRun
{
	static void Main(string[] args)
	{
		Logic logic = new Logic();
		Inventory inventory = new Inventory();
		bool keepgoing = true;


		while (keepgoing)
		{
			//Console.Clear();
			Console.WriteLine("Car Inventory Menu");
			Console.WriteLine();
			Console.WriteLine("There is currently " + inventory.InventoryLength() + " cars in the system.");
			Console.WriteLine();
			Console.WriteLine("1) Remove/Edit/Display car");
			Console.WriteLine("2) Display all cars");
			Console.WriteLine("3) Add car");
			Console.WriteLine("4) Exit");

			int input = logic.ConvertToInteger(Console.ReadLine());

			Console.Clear();

			if (input == 1) // Remove, Edit, Display car
			{
				Console.WriteLine("Please type in ID # of car");
				int carId = logic.ConvertToInteger(Console.ReadLine());
				while (inventory.SearchCar(carId) == null)
				{
					Console.WriteLine("Car does not exist");
					Console.WriteLine("Please input another ID number");
					carId = logic.ConvertToInteger(Console.ReadLine());
				}
				Car foundCar = inventory.SearchCar(carId);

				Console.WriteLine("Please input a number between 1-3");
				Console.WriteLine("1) Remove car");
				Console.WriteLine("2) Edit car");
				Console.WriteLine("3) Display car");
				Console.WriteLine("4) Exit");

				int input2 = logic.ConvertToInteger(Console.ReadLine());
				
				if (input2 == 1) // Remove car
				{
					Console.Clear();
					inventory.Display(foundCar);
					Console.WriteLine();
					Console.WriteLine("Are you sure that you want to remove car?");
					Console.WriteLine("1) Yes");
					Console.WriteLine("2) No");

					int i = logic.ConvertToInteger(Console.ReadLine());
					if (i == 1)
					{ inventory.RemoveCar(foundCar); }
				}
				else if (input2 == 2) // Edit car
				{
					Console.Clear();
					foundCar.Make = inventory.StringEditMethod(foundCar.Make, "make");
					Console.WriteLine(foundCar.Make);
					foundCar.Model = inventory.StringEditMethod(foundCar.Model, "model");
					Console.WriteLine(foundCar.Model);
					foundCar.Year = (int) inventory.DecimalEditMethod(foundCar.Year, "year");
					Console.WriteLine(foundCar.Year);
					foundCar.PurchasePrice = inventory.DecimalEditMethod(foundCar.PurchasePrice, "purchase price");
					Console.WriteLine(foundCar.PurchasePrice);
					foundCar.Miles = (int) inventory.DecimalEditMethod(foundCar.Miles, "miles");
					Console.WriteLine(foundCar.Miles);
					foundCar.SellingPrice = inventory.DecimalEditMethod(foundCar.SellingPrice, "selling price");
					Console.WriteLine(foundCar.SellingPrice);
					foundCar.SoldPrice = inventory.DecimalEditMethod(foundCar.SoldPrice, "sold price");
					Console.WriteLine(foundCar.SoldPrice);
					foundCar.Color = inventory.StringEditMethod(foundCar.Color, "color");
					Console.WriteLine(foundCar.Color);
					foundCar.ConditionSet(logic.Stringinput(Console.ReadLine()));
					foundCar.StatusSet(logic.Stringinput(Console.ReadLine()));
					foundCar.IsNew = (logic.ConvertToBool(Console.ReadLine()));
					inventory.UpdateCar(foundCar);
					Console.WriteLine("Car has been updated");
				}
				else if (input2 == 3) // Display car
				{
					inventory.Display(inventory.SearchCar(carId));
					Console.WriteLine();
					Console.ReadLine();
				}
				else
				{
					Console.Clear();
				}
			}
			else if (input == 2) // Display all cars
			{
				Console.Clear();
				Console.WriteLine("Displaying all cars");
				inventory.DisplayAll();
			}
			else if (input == 3) // Add car
			{
				Console.Clear();
				Console.WriteLine("Add a new car");
				Console.WriteLine();
				Car c = new Car();

				// Get ID Number
				Console.WriteLine("Please type an ID number for the car");
				int idNumber = logic.ConvertToInteger(Console.ReadLine());
				while (inventory.SearchCar(idNumber) == null)
				{
					Console.WriteLine("Id is invalid or already exsits");
					idNumber = logic.ConvertToInteger(Console.ReadLine());
				}
				c.IDNumber = idNumber;

				Console.WriteLine("Please type the car manufacturer");
				c.Make = logic.Stringinput(Console.ReadLine());
				Console.WriteLine("Please type the model of the car");
				c.Model = logic.Stringinput(Console.ReadLine());
				Console.WriteLine("Please type the year of the car");
				c.Year = logic.ConvertToInteger(Console.ReadLine());
				Console.WriteLine("Please type the purchase price of the car");
				c.PurchasePrice = logic.ConvertToDecimal(Console.ReadLine());
				Console.WriteLine("Please type the milage of the car");
				c.Miles = logic.ConvertToInteger(Console.ReadLine());
				Console.WriteLine("Please type the selling price of the car");
				c.SellingPrice = logic.ConvertToDecimal(Console.ReadLine());
				Console.WriteLine("Please type the sold price of the car");
				c.SoldPrice = logic.ConvertToDecimal(Console.ReadLine());
				Console.WriteLine("Please type the color of the car");
				c.Color = logic.Stringinput(Console.ReadLine());
				Console.WriteLine("Please type the condition of the car");
				Console.WriteLine("1 = Great, 2 = Good, 3 = Average, 4 = Terrible, 5 = Destroyed");
				c.ConditionSet(logic.Stringinput(Console.ReadLine()));
				Console.WriteLine("Please type the status of the car");
				Console.WriteLine("1 = In stock, 2 = On hold, 3 = Sold");
				c.StatusSet(logic.Stringinput(Console.ReadLine()));
				Console.WriteLine("Please type if the car is used or not");
				Console.WriteLine("1 = New, 2 = Used");
				c.IsNew = (logic.ConvertToBool(Console.ReadLine()));

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