using FluentAssertions;
using ToyRobotApp;
using Xunit;


namespace ToyRobot.Tests
{
    public class Report_ToyRobot
    {
        [Theory]
        [InlineData(0, 0, ToyRobotDirection.North, "0,0,NORTH")]
        [InlineData(1, 2, ToyRobotDirection.East, "1,2,EAST")]
        [InlineData(3, 4, ToyRobotDirection.South, "3,4,SOUTH")]
        [InlineData(4, 0, ToyRobotDirection.West, "4,0,WEST")]
        public void Return_position_when_it_is_valid(int x, int y, string direction, string report)
        {
            var toyRobot = new ToyRobotMain();
            toyRobot.Place(x, y, direction);

            var result = toyRobot.Report();

            result.Should().Be(report);
        }
    }
}
