using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            _Vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            _Vehicle["Frame"] = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            _Vehicle["Engine"] = "800 cc";
        }

        public override void BuildWheels()
        {
            _Vehicle["Wheels"] = "3";
        }

        public override void BuildDoors()
        {
            _Vehicle["Doors"] = "2";
        }

    }
}
