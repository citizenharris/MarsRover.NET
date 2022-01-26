using NUnit.Framework;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Test]
    public void MoveForwardOneSpace()
    {
        string output = new MarsRover().Execute("M");
        
        Assert.AreEqual("0:1:N", output);
    }

    [Test]
    public void MoveTwoStepsForward()
    {
        string output = new MarsRover().Execute("MM");
        
        Assert.AreEqual("0:2:N", output);
    }
}