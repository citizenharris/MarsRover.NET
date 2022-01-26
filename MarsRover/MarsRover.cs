namespace MarsRover;

public class MarsRover
{
    private string _direction;
    private readonly Location _location = new Location();

    public string Execute(string commands)
    {
        _direction = "N";
        
        foreach (var command in commands)
        {
            if (command == 'M')
            {
                _location._yCoordinate += 1;
            }

            if (_location._yCoordinate == 10)
            {
                _location._yCoordinate = 0;
            }
        }

        return $"{_location._xCoordinate}:{_location._yCoordinate}:{_direction}";
    }
}
