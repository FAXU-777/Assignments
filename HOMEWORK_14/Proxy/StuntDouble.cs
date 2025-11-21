namespace HOMEWORK_14;

public class StuntDouble : IActor
{
    
    public void PerformScene(string sceneType)
    {
        Console.WriteLine("Stunt double performs a dangerous scene " + sceneType);
    }
    
}