
List<ISystem>systems = new List<ISystem>() {new NewSystem(),new Adapter() ,new Adapter(),new NewSystem()};
foreach (var i in systems)
    i.Process();


public interface ISystem
{
    void Process();
}
public class OldSystem
{
    public void Execute()
    {
        Console.WriteLine("Old system executing...");
    }
}

public class NewSystem : ISystem
{
    public void Process()
    {
        Console.WriteLine("New System is processing..");
    }
}

public class Adapter :OldSystem, ISystem
{
    public void Process()
    {
        Execute();
    }
}
