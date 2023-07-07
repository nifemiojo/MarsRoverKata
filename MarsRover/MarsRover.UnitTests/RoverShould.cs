using NUnit.Framework;
using System;

namespace MarsRover.UnitTests
{
    [TestFixture]
    public class RoverShould
    {
        [Test]
        public void Not_Be_Null()
        {
            // Arrange
            var rover = new Rover();

            //Act

            //Assert
            Assert.That(rover, Is.Not.Null);
        }

        [TestCase(1, 2, 'N')]
        [TestCase(5, 5, 'S')]
        [TestCase(199, 199, 'N')]
        public void Have_Position_Initialised(int xCoordinate, int yCoordinate, char heading)
        {
            var rover = new Rover(xCoordinate, yCoordinate, heading);

            Assert.That(rover.Position, Is.Not.Null);
        }

        [Test]
        public void Throw_Argument_Exception_If_Position_Out_Of_Range()
        {
            Assert.Throws<ArgumentException>(() => new Rover(-1, 0, 'N'));
        }

    }
}
