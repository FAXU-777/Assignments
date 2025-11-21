namespace HomeWork_14;

class Program
{
    static void Main(string[] args)
    {
        IFurnitureFactory modernFactory = new ModernFurniture();
        Client Nika = new Client(modernFactory);
        Console.WriteLine();


        IFurnitureFactory artDecoFactory = new ArtDecoFurniture();
        Client Shota = new Client(artDecoFactory);
        Console.WriteLine();

        IFurnitureFactory VictorianFactory = new VictorianFurniture();
        Client Giorgi = new Client(VictorianFactory);

    }
}