using NUnit.Framework;

namespace MarsRover.Tests;

public class AcceptanceTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RoverCanMoveAndTurn()
    {
        var rover = new MarsRover();
        Assert.AreEqual(rover.Execute("MMRMMLM"), "2:3:N");
    }
}
