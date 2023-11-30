public class GamingComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void BuildProcessor()
    {
        computer.Processor = "Intel Core i7";
    }

    public void BuildMemory()
    {
        computer.Memory = "16GB RAM";
    }

    public void BuildGraphicsCard()
    {
        computer.GraphicsCard = "NVIDIA GeForce RTX 3080";
    }

    public void BuildStorage()
    {
        computer.Storage = "1TB SSD + 2TB HDD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}
