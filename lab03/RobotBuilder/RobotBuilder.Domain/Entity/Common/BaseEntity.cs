using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBuilder.Domain.Entity.Common
{
    public class BaseEntity
    {
        public string Name { get; set; }
        private bool _isTurnOnOrOff;

        public virtual void TurnOn()
        {
            _isTurnOnOrOff = true;
        }

        public virtual void TurnoOf()
        {
            _isTurnOnOrOff = false;
        }
    }
}
