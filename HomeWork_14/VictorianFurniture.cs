namespace HomeWork_14;

public class VictorianFurniture : IFurnitureFactory
{
    public Chair CreateChair()
    {
        Console.WriteLine("Victorian Chair is created");
        return new Chair();
    }

    public Sofa CreateSofa()
    {
        Console.WriteLine("Victorian sofa is created");
        return new Sofa();
    }

    public Table CreateTable()
    {
        Console.WriteLine("Victorian table is created");
        return new Table();
    }
}