namespace OOP;

public class Computer
{
    public Computer() // Constructor 
    {

    }

    private decimal? _price; // field
    public decimal? Price// Property
    { 
        get
        {
            return _price;
        }
        set
        {
            _price = value;
        }
    }

    public decimal? ReturnComputerPrice()//method
    {
        return ReturnValueIfPossible();
    }

    private bool CheckPrice()
    {
        // logic here and return the value
        return true;
    }
    private bool IsPermission()
    {
        return true;
    }

    private decimal? ReturnValueIfPossible()
    {
        if(CheckPrice() && IsPermission())
        {
            return Price;
        }
        return 0;
    }

    public virtual void ComputerType(string type)
    {
        // base class
    }
}
