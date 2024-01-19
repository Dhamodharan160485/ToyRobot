using FakeItEasy;
using ToyRobotApp;
using Xunit;

namespace ToyRobot.Tests
{
    public class Simulator_ToyRobot
    {
        [Theory]
        [InlineData("PLACE 0,0,NORTH", 0, 0, ToyRobotDirection.North)]
        [InlineData("PLACE 1,2,EAST", 1, 2, ToyRobotDirection.East)]
        [InlineData("PLACE 3,4,SOUTH", 3, 4, ToyRobotDirection.South)]
        [InlineData("PLACE 4,0,WEST", 4, 0, ToyRobotDirection.West)]
        public void Execute_Place_command(string command, int x, int y, string direction)
        {
            var toyRobot = A.Fake<ToyRobotMain>();
            var simulator = new ToyRobotSimulator(toyRobot);

            simulator.Execute(command);

            A.CallTo(() => toyRobot.Place(x, y, direction)).MustHaveHappened();
        }

        [Fact]
        public void Execute_Move_command()
        {
            var toyRobot = A.Fake<ToyRobotMain>();
            var simulator = new ToyRobotSimulator(toyRobot);
            toyRobot.Place(2, 2, ToyRobotDirection.North);

            simulator.Execute("MOVE");

            A.CallTo(() => toyRobot.Move()).MustHaveHappened();
        }

        [Fact]
        public void Execute_Left_command()
        {
            var toyRobot = A.Fake<ToyRobotMain>();
            var simulator = new ToyRobotSimulator(toyRobot);
            toyRobot.Place(2, 2, ToyRobotDirection.North);

            simulator.Execute("LEFT");

            A.CallTo(() => toyRobot.Left()).MustHaveHappened();
        }

        [Fact]
        public void Execute_Right_command()
        {
            var toyRobot = A.Fake<ToyRobotMain>();
            var simulator = new ToyRobotSimulator(toyRobot);
            toyRobot.Place(2, 2, ToyRobotDirection.North);

            simulator.Execute("RIGHT");

            A.CallTo(() => toyRobot.Right()).MustHaveHappened();
        }

        [Fact]
        public void Execute_Report_command()
        {
            var toyRobot = A.Fake<ToyRobotMain>();
            var simulator = new ToyRobotSimulator(toyRobot);
            toyRobot.Place(2, 2, ToyRobotDirection.North);

            simulator.Execute("REPORT");

            A.CallTo(() => toyRobot.Report()).MustHaveHappened();
        }
    }
}
