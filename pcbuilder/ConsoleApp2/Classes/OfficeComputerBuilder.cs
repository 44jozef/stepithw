public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void BuildProcessor()
    {
        computer.Processor = "Intel Core i5";
    }

    public void BuildMemory()
    {
        computer.Memory = "8GB RAM";
    }

    public void BuildGraphicsCard()
    {
        computer.GraphicsCard = "Integrated Graphics";
    }

    public void BuildStorage()
    {
        computer.Storage = "256GB SSD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}
