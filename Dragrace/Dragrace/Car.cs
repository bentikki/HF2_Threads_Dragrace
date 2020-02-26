using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dragrace
{
    class Car
    {
        public int RunNumber { get; private set; }
        public string Color { get; private set; }
        public IMotor Motor { get; private set; }

        public Car(int runNumber, string color, IMotor motor)
        {
            RunNumber = runNumber;
            Color = color;
            Motor = motor;
        }

    }
}
