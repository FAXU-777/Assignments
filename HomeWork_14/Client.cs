namespace HomeWork_14;

public class Client
{
    private Chair chair;
    private Sofa sofa;
    private Table table;

    public Client(IFurnitureFactory factory)
    {
        chair = factory.CreateChair();
        table = factory.CreateTable();
        sofa = factory.CreateSofa();

    }

}