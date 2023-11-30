public class DesignerComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void BuildProcessor()
    {
        computer.Processor = "AMD Ryzen 9";
    }

    public void BuildMemory()
    {
        computer.Memory = "32GB RAM";
    }

    public void BuildGraphicsCard()
    {
        computer.GraphicsCard = "NVIDIA Quadro P5000";
    }

    public void BuildStorage()
    {
        computer.Storage = "512GB NVMe SSD + 4TB HDD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}
