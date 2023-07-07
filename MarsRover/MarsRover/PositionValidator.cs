using System;
using System.Security.Cryptography.X509Certificates;

namespace MarsRover
{
    public class PositionValidator
    {

        public PositionValidator()
        {

        }
        public bool ValidatePosition(int xCoordinate, int yCoordinate, char heading)
        {
            if (xCoordinate < 0)
                throw new ArgumentException("xCoordinate must not be less than 0");
            if (yCoordinate < 0)
                throw new ArgumentException("yCoordinate must not be less than 0");
            if (heading != 'N' && heading != 'S' && heading != 'E' && heading != 'W')
                throw new ArgumentException("heading must be N, S, E or W");

            return true;
        }
    }
}