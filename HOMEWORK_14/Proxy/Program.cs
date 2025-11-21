namespace HOMEWORK_14;

class Program
{
    static void Main(string[] args)
    {
        IActor actor = new ActorProxy();
        actor.PerformScene("plda");
        actor.PerformScene("Simple");
        actor.PerformScene("dangerous");
    }
}