namespace ClassLibrary1;

public abstract class Product
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Name can\'t be null");
            }

            _name = value;
        }
    }
    private decimal _price;

    public decimal Price
    {
        get => _price;
        set
        {
            if (value <= 0)
            {
                throw new Exception("Price can\'t be less than 0");
            }

            _price = value;
        }

    }
    private int _count;

    public int Count
    {
        get => _count;
        set
        {
            if (value <= 0)
            {
                throw new Exception("Don't have it");
            }

            _count = value;
        }
    }
    
    public Product(string name, decimal price, int count)
    {
        _name = name;
        _price = price;
        _count = count;
    }
    
    public abstract void Display();
}