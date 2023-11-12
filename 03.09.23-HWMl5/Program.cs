#region Task1
/*
Money price = new(5, 50);   // Balance
Product product = new("Mouse", price);
product.Buy(2, 25);
product.Print();
class Money
{
    public int money { get; set; }
    public int cents { get; set; }

    public Money(int money, int cents)
    {
        this.money = money;
        this.cents = cents;
    }
    public void Print()
    {
        Console.WriteLine($"{money} dollars & {cents} cent");
    }
    public void ReBalance(int reMoney, int reCents)
    {
        money -= reMoney;
        cents -= reCents;
        if(cents >= 100) 
        { 
            cents -= 100;
            money += 1;
        }
        if(cents < 0)
        {
            money -= 1;
            cents += 100;
        }
    }
}
class Product
{
    public string name;
    public Money price;

    public Product(string name, Money price)
    {
        this.name = name;
        this.price = price;
    }
    public void Print() 
    {
        Console.WriteLine($"Product name: {name}");
        Console.WriteLine($"Product cost:");
        price.Print(); 
    }
    public void Buy(int reMoney, int reCents)
    {
        price.ReBalance(reMoney, reCents);
    }
}
*/
#endregion
#region Task2
/*
Kettle kettle = new();
Microwave microwave = new();
Car car = new Car();
Steamboat steamboat = new Steamboat();

kettle.Sound();
kettle.Show();
kettle.Desc();
Console.WriteLine();
microwave.Sound();
microwave.Show();
microwave.Desc();
Console.WriteLine();
car.Sound();
car.Show();
car.Desc();
Console.WriteLine();
steamboat.Sound();
steamboat.Show();
steamboat.Desc();
class Device
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Sound()
    {
        Console.WriteLine($"{Name} sound");
    }
    public void Show()
    {
        Console.WriteLine($"Device name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Description: {Description}");
    }
}
class Kettle : Device
{
    public Kettle(string name = "Kettle", string description = "Designed for boiling water")
        : base(name, description) { }
}
class Microwave : Device
{
    public Microwave(string name = "Microwave",string description = "An electrical appliance that allows you to warm up")
        : base(name, description) { }
}
class Car : Device
{
    public Car(string name = "Car",string description = "Autonomous trackless wheeled vehicle")
        : base(name, description) { }
}
class Steamboat : Device
{
    public Steamboat(string name = "Steamboat",string description = "Steam powered ship")
        : base(name, description) { }
}
*/
#endregion
#region Task3
/*
Violin violin = new();
Trombone trombone = new();
Ukulele ukulele = new();
Cello cello = new();

violin.Show();
violin.Sound();
violin.Desc();
violin.History();
Console.WriteLine();
trombone.Show();
trombone.Sound();
trombone.Desc();
trombone.History();
Console.WriteLine();
ukulele.Show();
ukulele.Sound();
ukulele.Desc();
ukulele.History();
Console.WriteLine();
cello.Show();
cello.Sound();
cello.Desc();
cello.History();
class MusicInstrument
{
    public string Name { get; set; }
    public string Description { get; set; }

    public string Hist { get; set; }

    public MusicInstrument(string name, string description, string hist)
    {
        Name = name;
        Description = description;
        Hist = hist;
    }
    public void Sound()
    {
        Console.WriteLine($"{Name}, makes a sound");
    }
    public void Show()
    {
        Console.WriteLine($"Tool name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Description: {Description}");
    }
    public void History()
    {
        Console.WriteLine($"History: {Hist}");
    }
}
class Violin : MusicInstrument
{
    public Violin(string name = "Violin", string description = "Bowed musical instrument with four strings", string hist = "Made in the 17th century") 
        : base(name, description, hist) { }
}
class Ukulele : MusicInstrument
{
    public Ukulele(string name = "Ukulele",string description = "Hawaiian four-string guitar", string hist = "Made in Hawaii")
       : base(name, description, hist) { }
}
class Trombone : MusicInstrument
{
    public Trombone(string name = "Trombone",string description = "European embouchure wind instrument", string hist = "Made in the 21st century")
        : base(name, description, hist) { }
}
class Cello : MusicInstrument
{
    public Cello(string name = "Cello",string description = "Bowed musical instrument", string hist = "Made in the 17th century")
        : base(name, description, hist) { }
}
*/
#endregion
#region Task4
/*
President president = new();
Security security = new();
Manager manager = new();
Engineer engineer = new();

president.Print();
security.Print();
manager.Print();
engineer.Print();
abstract class Worker
{
    public abstract void Print();
}
class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("This is the president of the company");
    }
}
class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("This is a company security guard");
    }
}
class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("This is the company manager");
    }
}
class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("This is a company engineer");
    }
}
*/
#endregion