using System;

public class Car
{
    public int IDNumber { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal PurchasePrice { get; set; }
    public int Miles { get; set; }
    public decimal SellingPrice { get; set; }
    public decimal SoldPrice { get; set; }
    public string Color { get; set; }
    public bool IsNew { get; set; }

    private string c;

    public string Condition
    {
        get { return c; }
        set { c = ConditionSet(value); }
    }


    public string ConditionSet(string value)
    {
        if (value == "1")
            return "Great";
        else if (value == "2")
            return "Good";
        else if (value == "3")
            return "Average";
        else if (value == "4")
            return "Terrible";
        else if (value == "5")
            return "Destoryed";
        else
            return "Not set";
    }

    private string s;

    public string Status
    {
        get { return s; }
        set { s = StatusSet(value); }
    }

    public string StatusSet(string value)
    {
        if (value == "1")
            return "In stock";
        else if (value == "2")
            return "On hold";
        else if (value == "3")
            return "Sold";
        else
            return "Not set";
    }
}
