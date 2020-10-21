using RobotBuilder.App.Concrete;
using RobotBuilder.App.Managers;
using System;

namespace RobotBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RobotService robotService = new RobotService("BB",8);

            RobotManager robotManager = new RobotManager(robotService);

            robotManager.StartRobot();
            robotService.Run();
            robotManager.StartRobot();
        }
    }
}
