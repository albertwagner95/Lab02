using RobotBuilder.App.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBuilder.App.Managers
{
    public class RobotManager
    {
        private readonly IRobot _robotService;
        public RobotManager(IRobot robotService)
        {
            _robotService = robotService;
        }

        public void GiveSignal()
        {
            var isTurnOn = _robotService.IsTurnOn();
            
            if(isTurnOn)
            {
                Console.WriteLine("Signal: Wrrrp bleep");
            }
        }

        public void StartRobot()
        {
            var robotSignal = _robotService.ReturnRobotSeries();
            Console.WriteLine($"{robotSignal}");
            GiveSignal();
        }

    }
}
