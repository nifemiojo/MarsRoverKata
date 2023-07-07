using System;

namespace MarsRover
{
    public class Rover
    {
        public PositionValidator PositionValidator;
        public Position Position { get; set; }

	    public Rover(int xCoordinate, int yCoordinate, char heading)
	    {
            PositionValidator = new PositionValidator();
            var isValid = PositionValidator.ValidatePosition(xCoordinate, yCoordinate, heading);

            if (isValid)
            {
		        Position = new Position{ X = xCoordinate, Y = yCoordinate, Heading = heading };
            }
	    }

	    public void PerformInstruction(char instruction)
	    {
            if (instruction == 'M')
            {
                Position.Y++;
            }

            if (instruction == 'R')
            {
				Position.Heading = 'E';
			}
	    }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Heading { get; set; }
    }
}
