using NUnit.Framework;

namespace MarsRover.Tests;

public class MarsRoverShould
{
    [Test]
    [TestCase("M", "0:1:N")]
    [TestCase("MM", "0:2:N")]
    [TestCase("MMM", "0:3:N")]
    [TestCase("MMMMMMMMMM", "0:0:N")]
    public void MoveForward(string commands, string expectedOutput)
    {
        string output = new MarsRover().Execute(commands);
        
        Assert.AreEqual(expectedOutput, output);
    }

    [Test]
    public void TurnLeftCommand()
    {
        var output = new MarsRover().Execute("L");
        Assert.AreEqual("0:0:W", output);
    }
}