namespace OOP;

public class Laptop : Computer, IKeyboard
{
    // you can put your logic here
    public void DefineTypeOfKeyboard()
    {
        throw new NotImplementedException();
    }

    public decimal? ReturnPrice(decimal Tax)
    {
        return Price + (Price * (Tax / 100));
    }

    public decimal? ReturnPrice(decimal Tax, string color)
    {
        if (color == "Red")
        {
            Price = Price + 1;
        }
        else
        {
            Price = Price != 0 ? Price - 1 : 0;
        }
        return Price + (Price * (Tax / 100));
    }

    //public override void ComputerType(string type)
    //{
    //    base.ComputerType(type);
    //    // you can change logic here
    //}

    public new void ComputerType()//method hiding
    {
        // logic here
    }
}


//public class Laptop : SealedExampleClass
//{

//}
