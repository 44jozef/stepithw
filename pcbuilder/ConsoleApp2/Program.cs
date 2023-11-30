using System;

class Program
{
    static void Main()
    {
        var officeComputerBuilder = new OfficeComputerBuilder();
        var gamingComputerBuilder = new GamingComputerBuilder();
        var designerComputerBuilder = new DesignerComputerBuilder();

        var director = new ComputerDirector();

        director.ConstructComputer(officeComputerBuilder);
        var officeComputer = officeComputerBuilder.GetComputer();

        director.ConstructComputer(gamingComputerBuilder);
        var gamingComputer = gamingComputerBuilder.GetComputer();

        director.ConstructComputer(designerComputerBuilder);
        var designerComputer = designerComputerBuilder.GetComputer();

        Console.WriteLine("Office Computer:");
        officeComputer.DisplayInfo();

        Console.WriteLine("\nGaming Computer:");
        gamingComputer.DisplayInfo();

        Console.WriteLine("\nDesigner Computer:");
        designerComputer.DisplayInfo();
    }
}
