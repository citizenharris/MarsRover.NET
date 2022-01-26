namespace MarsRover;

public record Location(int XCoordinate, int YCoordinate)
{
    public override string ToString()
    {
        return $"{XCoordinate}:{YCoordinate}";
    }
}
