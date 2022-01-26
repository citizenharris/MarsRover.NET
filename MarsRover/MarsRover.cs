namespace MarsRover;

public class MarsRover
{
    private Location _location = new Location(0, 0);
    private readonly Direction _direction = new Direction();

    public string Execute(string commands)
    {
        foreach (var command in commands)
        {
            if (command == 'L')
            {
                _direction.TurnLeft();
            }

            if (command == 'M')
            {
                _location = _location with {YCoordinate = _location.YCoordinate + 1};
            }

            if (_location.YCoordinate == 10)
            {
                _location = _location with {YCoordinate = 0};
            }
        }
        Console.WriteLine(_location.ToString());
        return $"{_location}:{_direction}";
    }
}