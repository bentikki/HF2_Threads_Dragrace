using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragrace
{
    class Poyota : IMotor
    {
        private int accelerateDistance;
        private double accelerateSpeed;
        private int topSpeed;

        public int AccelerateDistance
        {
            get
            {
                return this.accelerateDistance;
            }
            private set
            {
                this.accelerateDistance = value;
            }
        }
        public double AccelerateSpeed
        {
            get
            {
                return this.accelerateSpeed;

            }
            private set
            {
                this.accelerateSpeed = value;
            }
        }
        public int TopSpeed
        {
            get
            {
                return this.topSpeed;
            }
            private set
            {
                this.topSpeed = value;
            }
        }
        public Poyota()
        {
            AccelerateDistance = 100;
            AccelerateSpeed = 4;
            TopSpeed = 330;
        }
    }
}
