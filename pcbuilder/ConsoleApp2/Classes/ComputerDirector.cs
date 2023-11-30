public class ComputerDirector
{
    public void ConstructComputer(IComputerBuilder builder)
    {
        builder.BuildProcessor();
        builder.BuildMemory();
        builder.BuildGraphicsCard();
        builder.BuildStorage();
    }
}
