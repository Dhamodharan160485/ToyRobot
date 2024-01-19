using FluentAssertions;
using ToyRobotApp;
using Xunit;

namespace ToyRobot.Tests
{
    public class Main_ToyRobot
    {
        [Fact]
        public void Discard_Move_command_when_the_robot_was_not_placed_on_the_table()
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Move();

            toyRobot.X.Should().Be(null);
            toyRobot.Y.Should().Be(null);
            toyRobot.Facing.Should().Be(null);
        }

        [Fact]
        public void Discard_Left_command_when_the_robot_was_not_placed_on_the_table()
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Left();

            toyRobot.X.Should().Be(null);
            toyRobot.Y.Should().Be(null);
            toyRobot.Facing.Should().Be(null);
        }

        [Fact]
        public void Discard_Right_command_when_the_robot_was_not_placed_on_the_table()
        {
            var toyRobot = new ToyRobotMain();

            toyRobot.Right();

            toyRobot.X.Should().Be(null);
            toyRobot.Y.Should().Be(null);
            toyRobot.Facing.Should().Be(null);
        }

        [Fact]
        public void Discard_Report_command_when_the_robot_was_not_placed_on_the_table()
        {
            var toyRobot = new ToyRobotMain();

            var result = toyRobot.Report();

            result.Should().Be(null);
        }
    }
}
