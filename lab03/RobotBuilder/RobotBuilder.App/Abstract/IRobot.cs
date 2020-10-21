using RobotBuilder.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBuilder.App.Abstract
{
    public interface IRobot
    {
        void Run();
        bool IsTurnOn();
        string ReturnRobotSeries();
    }
}
