using System;

public class Car
{
    public int IDNumber { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int PurchasePrice { get; set; }
    public int Miles { get; set; }
    public int SellingPrice { get; set; }
    public int SoildPrice { get; set; }
    public bool New { get; set; }
    public string Color { get; set; }

    public string Condition(int value)
    {
        if (value == 1)
            return "Factory new";
        else if (value == 2)
            return "Good condition";
        else if (value == 3)
            return "Average condition";
        else if (value == 4)
            return "Terrible codition";
        else if (value == 5)
            return "Destoryed";
    }

    public string Status()
    {

    }
}
