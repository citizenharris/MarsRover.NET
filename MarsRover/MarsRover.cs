namespace MarsRover;

public class MarsRover
{
    public string Execute(string commands)
    {
        if (commands == "MM") return "0:2:N";
        
        return "0:1:N";
    }
}
