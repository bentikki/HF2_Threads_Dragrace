using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragrace
{
    class Program
    {
        static void Main(string[] args)
        {
            Race dragRace = new Race
            (
                new List<Car>
                {
                    new Car(1, "Red", new Jondamotor() ),
                    new Car(2, "Blue", new Poyota() ),
                    new Car(3, "Green", new Jondamotor() ),
                    new Car(4, "Yellow", new Jondamotor() ),
                }
            );

            dragRace.Start();
        }
    }
}
