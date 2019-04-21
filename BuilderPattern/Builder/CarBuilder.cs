using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            _Vehicle = new Vehicle("CAR");
        }

        public override void BuildFrame()
        {
            _Vehicle["Frame"] = "CAR Frame";
        }

        public override void BuildEngine()
        {
            _Vehicle["Engine"] = "1800 cc";
        }

        public override void BuildWheels()
        {
            _Vehicle["Wheels"] = "4";
        }

        public override void BuildDoors()
        {
            _Vehicle["Doors"] = "2";
        }

    }
}
