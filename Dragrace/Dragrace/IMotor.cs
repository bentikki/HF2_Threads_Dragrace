using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragrace
{
    interface IMotor
    {
        int TopSpeed { get; }
        int AccelerateDistance{ get; }
        double AccelerateSpeed { get; }
    }
}
