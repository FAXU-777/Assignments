namespace HomeWork_14;

public class ModernFurniture : IFurnitureFactory
{
 
    public Chair CreateChair()
    {
        Console.WriteLine("Modern Chair is created");
        return new Chair();
    }

    public Sofa CreateSofa()
    {
        Console.WriteLine("Modern sofa is created");
        return new Sofa();
    }

    public Table CreateTable()
    {
        Console.WriteLine("Modern Table is created");
        return new Table();

    }
    
}