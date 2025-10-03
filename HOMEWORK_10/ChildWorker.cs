namespace HOMEWORK_10;

public class ChildWorker : FileWorker
{
    public ChildWorker(int maxSize, string extention) : base(maxSize, extention)
    {
    }
    public override void Read()
    {
        Console.WriteLine($"I can read from a {Extention} file with max size: {MaxSize} MB.");
    }

    public override void Write()
    {
        Console.WriteLine($"I can write to a {Extention} file with max size: {MaxSize} MB.");
    }

    public override void Edit()
    {
        Console.WriteLine($"I can edit a {Extention} file with max size: {MaxSize} MB.");
    }

    public override void Delete()
    {
        Console.WriteLine($"I can delete a {Extention} file with max size: {MaxSize} MB.");
    }
}