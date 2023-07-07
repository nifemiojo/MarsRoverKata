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
            var rover = new Rover(0,0,'N');

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

        [TestCase(-1, 0, 'N')]
        [TestCase(1, -1, 'N')]
        [TestCase(1, 1, 'Z')]
        public void Throw_Argument_Exception_If_Position_Out_Of_Range(int xCoordinate, int yCoordinate, char heading)
        {
            Assert.Throws<ArgumentException>(() => new Rover(xCoordinate, yCoordinate, heading));
        }

        [Test]
        public void Move_Forward()
        {
	        var rover = new Rover(0, 0, 'N');

	        rover.PerformInstruction('M');

            Assert.That(rover.Position.X, Is.EqualTo(0));
            Assert.That(rover.Position.Y, Is.EqualTo(1));
            Assert.That(rover.Position.Heading, Is.EqualTo('N'));
        }
        
        [Test]
        public void Move_Forward_With_Different_Heading()
        {
	        var rover = new Rover(2, 2, 'E');

	        rover.PerformInstruction('M');

            Assert.That(rover.Position.X, Is.EqualTo(3));
            Assert.That(rover.Position.Y, Is.EqualTo(2));
            Assert.That(rover.Position.Heading, Is.EqualTo('E'));
        }

        
        [Test]
        public void Change_Heading_Direction_R()
        {
	        var rover = new Rover(0, 0, 'N');

	        rover.PerformInstruction('R');

            Assert.That(rover.Position.X, Is.EqualTo(0));
            Assert.That(rover.Position.Y, Is.EqualTo(0));
            Assert.That(rover.Position.Heading, Is.EqualTo('E'));
        }

	}
}
