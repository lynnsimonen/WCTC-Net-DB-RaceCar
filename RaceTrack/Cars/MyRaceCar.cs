using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class MyRaceCar : RaceCar
    {
        public MyRaceCar()
        {
            Name = "Porsche";
            TopSpeed = 150;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} races down the track");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is lowering speeds!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} stops!");
        }
    }
}