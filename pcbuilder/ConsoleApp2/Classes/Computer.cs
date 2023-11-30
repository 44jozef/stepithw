// Computer.cs
public class Computer
{
    public string Processor { get; set; }
    public string Memory { get; set; }
    public string GraphicsCard { get; set; }
    public string Storage { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Processor: {Processor}");
        Console.WriteLine($"Memory: {Memory}");
        Console.WriteLine($"Graphics Card: {GraphicsCard}");
        Console.WriteLine($"Storage: {Storage}");
    }
}
