namespace HOMEWORK_10;

class Program
{
    static void Main(string[] args)
    {
        ChildWorker childWorker = new ChildWorker(128, "Txt");
        childWorker.Delete();
        childWorker.Edit();
        childWorker.Read();
        childWorker.Write();
    }
}