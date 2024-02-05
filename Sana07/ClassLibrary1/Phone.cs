namespace ClassLibrary1;

public class Phone : Product
{
    private string _OS;
    public string OS
    {
        get => _OS;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("OS can't be null");
            }

            _OS = value;
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
                throw new Exception("Model can\'t be null");
            }

            _model = value;
        }
    }
    
    public Phone(string name, decimal price, int count, string os, string model) : base(name, price, count)
    {
        OS = os;
        Model = model;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}\nPrice: {Price}$\nCount: {Count}\nOS: {OS}\nModel: {Model}\n");
    }
}