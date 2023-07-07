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
            Position = new Position();
            Position.X = xCoordinate;
            Position.Y = yCoordinate;
            Position.Heading = heading;
        }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Heading { get; set; }
    }
}
