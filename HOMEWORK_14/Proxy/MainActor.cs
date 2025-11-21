namespace HOMEWORK_14;

public class MainActor : IActor
{
    public void PerformScene(string sceneType)
    {
        Console.WriteLine("Main actor performs the scene " + sceneType);
    }
}