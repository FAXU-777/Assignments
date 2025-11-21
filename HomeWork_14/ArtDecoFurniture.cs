namespace HomeWork_14;

public class ArtDecoFurniture : IFurnitureFactory
{
    public Chair CreateChair()
    {
        Console.WriteLine("ArtDeco Chair is created");
        return new Chair();
    }

    public Sofa CreateSofa()
    {
        Console.WriteLine("ArtDeco sofa is created");
        return new Sofa();
    }

    public Table CreateTable()
    {
        Console.WriteLine("ArtDeco table is created");
        return new Table();
    }
}