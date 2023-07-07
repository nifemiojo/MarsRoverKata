using NUnit.Framework;

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

        [Test]
        public void Have_Position_Initialised()
        {
            var rover = new Rover(1, 2, "N");

            Assert.That(rover.Position, Is.Not.Null);
        }

    }
}
