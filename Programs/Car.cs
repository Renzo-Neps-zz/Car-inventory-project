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
    public int SoldPrice { get; set; }
    public string Color { get; set; }

    /*private string c;

    public string Condition
    {
        get { return c; }
        set { c = Condition(value); }
    }


    public string Condition(int value)
    {
        if (value == 1)
            return "Great";
        else if (value == 2)
            return "Good";
        else if (value == 3)
            return "Average";
        else if (value == 4)
            return "Terrible";
        else if (value == 5)
            return "Destoryed";
        else
            return "Please, input a number 1-5";
    }

    public string Status(int value)
    {
        if (value == 1)
            return "In stock";
        else if (value == 2)
            return "On hold";
        else if (value == 3)
            return "Sold";
        else
            return "Please, input a number 1-3";
    }

    public string New(bool new)
    {
        if (new)
            return "New";
        else
            return "Used";
    }*/
}
