namespace HOMEWORK_10;

public abstract class FileWorker
{
    protected int MaxSize { get; set; }
    protected string Extention;

    public FileWorker(int maxSize, string extention)
    {
        this.MaxSize = maxSize;
        this.Extention = extention;
    }
    public abstract void Read();
    public abstract void Write();
    public abstract void Edit();
    public abstract void Delete();

}