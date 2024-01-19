using FluentAssertions;
using ToyRobotApp;
using Xunit;

namespace ToyRobot.Tests
{
    public class Place_ToyRobot
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void Set_robots_X_position(int x)
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Place(x, 2, ToyRobotDirection.South);

            toyRobot.X.Should().Be(x);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void Set_robots_Y_position(int y)
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Place(1, y, ToyRobotDirection.South);

            toyRobot.Y.Should().Be(y);
        }

        [Theory]
        [InlineData(ToyRobotDirection.North)]
        [InlineData(ToyRobotDirection.South)]
        [InlineData(ToyRobotDirection.East)]
        [InlineData(ToyRobotDirection.West)]
        public void Set_robots_direction(string direction)
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Place(1, 2, direction);

            toyRobot.Facing.Should().Be(direction);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(5)]
        [InlineData(6)]
        public void Discard_command_when_X_is_invalid(int x)
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Place(x, 2, ToyRobotDirection.South);

            toyRobot.X.Should().NotBe(x);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(5)]
        [InlineData(6)]
        public void Discard_command_when_Y_is_invalid(int y)
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Place(1, y, ToyRobotDirection.South);

            toyRobot.Y.Should().NotBe(y);
        }

        [Theory]
        [InlineData("")]
        [InlineData("A")]
        [InlineData("BB")]
        [InlineData("CCC")]
        public void Discard_command_when_direction_is_invalid(string direction)
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Place(1, 2, direction);

            toyRobot.Facing.Should().NotBe(direction);
        }
    }
}
