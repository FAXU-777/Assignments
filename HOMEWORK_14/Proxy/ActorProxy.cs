namespace HOMEWORK_14;

public class ActorProxy : IActor
{
    private MainActor mainActor = new MainActor();
    private StuntDouble stuntDouble = new StuntDouble();
    
    
    
    public void PerformScene(string sceneType)
    {
        switch (sceneType.ToLower())
        {
            case "simple":
                Console.WriteLine("Proxy: Delegating to main actor for simple scene.");
                break;
            case "dangerous":
                Console.WriteLine("Proxy: Delegating to stunt double for dangerous scene.");
                break;
            default:
                Console.WriteLine("Proxy: Unknown scene type. Cannot delegate.");
                return;
        }
    }
}