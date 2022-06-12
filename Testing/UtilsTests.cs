using Mars_Rover.Factories;
using Mars_Rover.Models;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class UtilsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 2)]
        [TestCase(5, 4)]
        public void GeneratePositionWorks(int x, int y)
        {
            var pos1 = new Position(x, y);
            var pos2 = Utils.GeneratePosition(x, y);
            Assert.IsTrue(pos1 == pos2);
        }
    }
}