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

    }
}
