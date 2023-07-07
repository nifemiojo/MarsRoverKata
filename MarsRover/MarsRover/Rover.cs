using System;

namespace MarsRover
{
    public class Rover
    {
        public Position Position { get; set; }

        public Rover()
        {
		}

	    public Rover(int xCoordinate, int yCoordinate, char heading)
	    {
		    if (xCoordinate < 0)
			    throw new ArgumentException("xCoordinate must not be less than 0");
            if (yCoordinate < 0)
                throw new ArgumentException("yCoordinate must not be less than 0");
            if (heading != 'N' || heading != 'S' || heading != 'E' || heading != 'W')
                throw new ArgumentException("heading must be N, S, E or W");

		    Position = new Position{ X = xCoordinate, Y = yCoordinate, Heading = heading };
	    }

	    public Position PerformInstructions(string s)
	    {
		    throw new NotImplementedException();
	    }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Heading { get; set; }
    }
}
