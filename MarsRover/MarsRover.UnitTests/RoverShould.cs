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

        [TestCase(0, 0, 'N', 0, 1, 'N')]
        [TestCase(2, 2, 'E', 3, 2, 'E')]
        [TestCase(4, 4, 'S', 4, 3, 'S')]
        [TestCase(4, 4, 'W', 3, 4, 'W')]
        public void Move_Forward_Instruction_Works_With_Any_Heading(int xCoordinate, int yCoordinate, char heading, int expectedXCoordinate, int expectedYCoordinate, char expectedHeading)
        {
            var rover = new Rover(xCoordinate, yCoordinate, heading);

            rover.PerformInstruction('M');

            Assert.That(rover.Position.X, Is.EqualTo(expectedXCoordinate));
            Assert.That(rover.Position.Y, Is.EqualTo(expectedYCoordinate));
            Assert.That(rover.Position.Heading, Is.EqualTo(expectedHeading));
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


        [Test]
        public void Change_Heading_Direction_L()
        {
            var rover = new Rover(0, 0, 'N');

            rover.PerformInstruction('L');

            Assert.That(rover.Position.X, Is.EqualTo(0));
            Assert.That(rover.Position.Y, Is.EqualTo(0));
            Assert.That(rover.Position.Heading, Is.EqualTo('W'));
        }

    }
}
