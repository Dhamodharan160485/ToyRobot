using System;
using System.IO;
using System.Linq;

namespace ToyRobotApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputFiles = args.Where(File.Exists);

            foreach (var path in inputFiles)
            {
                Console.WriteLine("Executing commands from: " + path);
                Console.WriteLine();

                ExecuteCommandsFrom(path);

                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void ExecuteCommandsFrom(string path)
        {
            var toyRobot = new ToyRobotMain();
            var simulator = new ToyRobotSimulator(toyRobot);

            using (var file = new StreamReader(path))
            {
                string command;
                while ((command = file.ReadLine()) != null)
                {
                    Console.WriteLine("Executing command: " + command);
                    simulator.Execute(command);
                }
            }
        }
    }
}