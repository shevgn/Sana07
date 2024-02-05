namespace ClassLibrary1;

public class Laptop : Product
{
    private float _size;
    public float Size
    {
        get => _size;
        set
        {
            if (value <= 0)
            {
                throw new Exception("Size can\'t be less than 0");
            }

            _size = value;
        }
    }
    private string _model;
    public string Model
    {
        get => _model;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("We need some model");
            }

            _model = value;
        }
    }
    private string _color;
    public string Color
    {
        get => _color;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("We need some color");
            }

            _color = value;
        }
    }
    
    public Laptop(string name, decimal price, int count, float size, string model, string color) 
        : base(name, price, count)
    {
        _size = size;
        _model = model;
        _color = color;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}\nPrice: {Price}$\nCount: {Count}\nModel: {Model}\nSize: {Size}\nColor: {Color}\n");
    }
}