using FluentAssertions;
using Xunit;
using ToyRobotApp;

namespace ToyRobot.Tests
{
    public class Left_ToyRobot
    {
        [Theory]
        [InlineData(ToyRobotDirection.North, ToyRobotDirection.West)]
        [InlineData(ToyRobotDirection.East, ToyRobotDirection.North)]
        [InlineData(ToyRobotDirection.South, ToyRobotDirection.East)]
        [InlineData(ToyRobotDirection.West, ToyRobotDirection.South)]
        public void Rotate_robot_left_90_degrees(string before, string after)
        {
            var toyRobot = new ToyRobotMain();
            toyRobot.Place(1, 1, before);

            toyRobot.Left();

            toyRobot.Facing.Should().Be(after);
        }
    }
}

