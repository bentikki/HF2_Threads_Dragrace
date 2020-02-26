using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dragrace
{

    class Race
    {
        static object _winner = new object();
        private Car winningCar;
        public int RaceLength { get; private set; }
        public List<Car> Contestants { get; private set; }

        public Race(List<Car> Contestants, int RaceLength = 400)
        {
            this.Contestants = Contestants;
            this.RaceLength = RaceLength;
        }

        public void Start()
        {
            Thread carThread;
            List<Thread> _machineThreads = new List<Thread>();
            foreach (Car car in Contestants)
            {
                carThread = new Thread(Drive);
                _machineThreads.Add(carThread);
                carThread.Start(car);
            }

            foreach (Thread machineThread in _machineThreads)
            {
                machineThread.Join();
            }
            PrintMessage.Print($"The race has ended!");

        }


        public void Drive(object carObj)
        {

            Stopwatch mywatch = new Stopwatch();
            mywatch.Start();

            Car car = (Car)carObj;
            int totalSpeedInMS = (int)(car.Motor.AccelerateSpeed * 1000);
            int newDistance = RaceLength;
            int maxSpeedDistance = newDistance - car.Motor.AccelerateDistance;
            int mps = Converter.KphToMph(car.Motor.TopSpeed);
            decimal timeTaken = Math.Round(Decimal.Divide(maxSpeedDistance, mps), 3);
            totalSpeedInMS += (int)(timeTaken * 1000);
            Thread.Sleep(totalSpeedInMS );
            
            lock (_winner)
            {
                if(winningCar == null)
                {
                    winningCar = car;
                    PrintMessage.Print($"Car No:{car.RunNumber} is the winner!");
                }
                mywatch.Stop();
                PrintMessage.Print($"Car No:{car.RunNumber} with the {car.Color} car, has finished in {mywatch.ElapsedMilliseconds } ms!");

            }


        }
    }


}
