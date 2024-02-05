namespace ClassLibrary1;

public class Backpack : Product
{
    private float _volume;
    public float Volume
    {
        get => _volume;
        set
        {
            if (value <= 0) throw new Exception("Volume must be greater than 0");
            
            _volume = value;
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
                throw new Exception("Color must be");
            }

            _color = value;
        }
    }
    
    public Backpack(string name, decimal price, int count, float volume, string color) : base(name, price, count)
    {
        _volume = volume;
        _color = color;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}\nPrice: {Price}$\nCount: {Count}\nVolume: {Volume} L\nColor: {Color}\n");
    }
}