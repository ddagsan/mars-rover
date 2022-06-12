using Mars_Rover;
using Mars_Rover.Factories;
using Mars_Rover.Models;
using Mars_Rover.Models.Enums;
using NUnit.Framework;
using System;

namespace Testing
{
    [TestFixture]
    public class Tests
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

        [Test]
        [TestCase(CompassPoint.North, CompassPoint.East)]
        [TestCase(CompassPoint.East, CompassPoint.South)]
        [TestCase(CompassPoint.South, CompassPoint.West)]
        [TestCase(CompassPoint.West, CompassPoint.North)]
        public void TurnRightWorks(CompassPoint before, CompassPoint after)
        {
            var vehicle = new Rover(Utils.GeneratePosition(1, 2), before);
            vehicle.TurnRight();
            Assert.AreEqual(vehicle.CurrentCompassPoint, after);
        }

        [Test]
        [TestCase(CompassPoint.North, CompassPoint.West)]
        [TestCase(CompassPoint.East, CompassPoint.North)]
        [TestCase(CompassPoint.South, CompassPoint.East)]
        [TestCase(CompassPoint.West, CompassPoint.South)]
        public void TurnLeftWorks(CompassPoint before, CompassPoint after)
        {
            var vehicle = new Rover(Utils.GeneratePosition(1, 2), before);
            vehicle.TurnLeft();
            Assert.AreEqual(vehicle.CurrentCompassPoint, after);
        }

        [Test]
        public void CreationOfCoordinatorCompletedFailure()
        {
            var rectangle = new Rectangle(10, 10);
            var vehicle = new Rover(Utils.GeneratePosition(11, 10), CompassPoint.North);
            
            Assert.Throws<InvalidOperationException>(() => 
            {
                var coordinator = new Coordinator(rectangle, vehicle, "LMLMLMLMM");
            });
        }

        [Test]
        public void CreationOfCoordinatorCompletedSuccessfully()
        {
            var rectangle = new Rectangle(10, 10);
            var vehicle = new Rover(Utils.GeneratePosition(10, 10), CompassPoint.North);
            var coordinator = new Coordinator(rectangle, vehicle, "LMLMLMLMM");
        }
    }
}