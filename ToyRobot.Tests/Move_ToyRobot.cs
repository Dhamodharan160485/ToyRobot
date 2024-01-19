using FluentAssertions;
using ToyRobotApp;
using Xunit;

namespace ToyRobot.Tests
{
    public class Move_ToyRobot
    {
        [Fact]
        public void Move_North_when_facing_North()
        {
            var toyRobot = new ToyRobotMain();
            toyRobot.Place(2, 2, ToyRobotDirection.North);

            toyRobot.Move();

            toyRobot.X.Should().Be(2);
            toyRobot.Y.Should().Be(3);
        }

        [Fact]
        public void Move_East_when_facing_East()
        {
            var toyRobot = new ToyRobotMain();
            toyRobot.Place(2, 2, ToyRobotDirection.East);

            toyRobot.Move();

            toyRobot.X.Should().Be(3);
            toyRobot.Y.Should().Be(2);
        }

        [Fact]
        public void Move_South_when_facing_South()
        {
            var toyRobot = new ToyRobotMain();
            toyRobot.Place(2, 2, ToyRobotDirection.South);

            toyRobot.Move();

            toyRobot.X.Should().Be(2);
            toyRobot.Y.Should().Be(1);
        }

        [Fact]
        public void Move_West_when_facing_West()
        {
            var toyRobot = new ToyRobotMain();
            toyRobot.Place(2, 2, ToyRobotDirection.West);

            toyRobot.Move();

            toyRobot.X.Should().Be(1);
            toyRobot.Y.Should().Be(2);
        }

        [Theory]
        [InlineData(4, 4, ToyRobotDirection.North)]
        [InlineData(4, 4, ToyRobotDirection.East)]
        [InlineData(0, 0, ToyRobotDirection.South)]
        [InlineData(0, 0, ToyRobotDirection.West)]
        public void Not_cause_the_robot_to_fall_outside_the_table(int x, int y, string direction)
        {
            var toyRobot = new ToyRobotMain();
            toyRobot.Place(x, y, direction);

            toyRobot.Move();

            toyRobot.X.Should().Be(x);
            toyRobot.Y.Should().Be(y);
        }
    }
}
