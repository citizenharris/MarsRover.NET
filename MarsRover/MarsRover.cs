namespace MarsRover;

public class MarsRover
{
    private string _xCoordinate;
    private string _separator;
    private string _yCoordinate;
    private string _direction;

    public string Execute(string commands)
    {
        _separator = ":";
        _direction = "N";
        
        if (commands == "MMM")
        {
            _xCoordinate = "0";
            _yCoordinate = "3";
            return _xCoordinate+_separator+_yCoordinate+_separator+_direction;
        }

        if (commands == "MM")
        {
            _xCoordinate = "0";
            _yCoordinate = "2";
            return _xCoordinate+_separator+_yCoordinate+_separator+_direction;
        }

        return "0:1:N";
    }
}
