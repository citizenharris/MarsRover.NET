namespace MarsRover;

public class MarsRover
{
    private int _xCoordinate;
    private int _yCoordinate;
    private string _direction;

    public string Execute(string commands)
    {
        _direction = "N";
        
        foreach (var command in commands)
        {
            if (command == 'M')
            {
                _yCoordinate += 1;
            }
        }

        return $"{_xCoordinate}:{_yCoordinate}:{_direction}";
    }
}
