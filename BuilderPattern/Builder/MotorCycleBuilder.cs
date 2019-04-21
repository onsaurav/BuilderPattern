using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            _Vehicle = new Vehicle("Motor Cycle");
        }

        public override void BuildFrame()
        {
            _Vehicle["Frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            _Vehicle["Engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            _Vehicle["Wheels"] = "2";
        }

        public override void BuildDoors()
        {
            _Vehicle["Doors"] = "0";
        }
    }
}
