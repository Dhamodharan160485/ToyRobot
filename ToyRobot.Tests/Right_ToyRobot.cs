using FluentAssertions;
using ToyRobotApp;
using Xunit;

namespace ToyRobot.Tests
{
    public class Right_ToyRobot
    {
        [Theory]
        [InlineData(ToyRobotDirection.North, ToyRobotDirection.East)]
        [InlineData(ToyRobotDirection.East, ToyRobotDirection.South)]
        [InlineData(ToyRobotDirection.South, ToyRobotDirection.West)]
        [InlineData(ToyRobotDirection.West, ToyRobotDirection.North)]
        public void Rotate_robot_right_90_degrees(string before, string after)
        {
            var toyRobot = new ToyRobotMain();
            toyRobot.Place(1, 1, before);

            toyRobot.Right();

            toyRobot.Facing.Should().Be(after);
        }
    }
}
