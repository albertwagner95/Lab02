using RobotBuilder.App.Abstract;
using RobotBuilder.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBuilder.App.Concrete
{
    public class RobotService : IRobot
    {
        public Robot Robot;

        public RobotService(string seriesCode, int seriesNumber)
        {
            Robot = new Robot(seriesCode,seriesNumber);
        }

        

        public bool IsTurnOn()
        {
            return Robot.isTurnOn;
        }

        public void Run()
        {
            Robot.isTurnOn = true;
        }

        public string ReturnRobotSeries()
        {
            string series = Robot.Series;

            return series;
        }

    }
}
