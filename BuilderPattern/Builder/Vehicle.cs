using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class Vehicle
    {
        private string _VehicleType;
        private string[] _PartsType = new string[] { "Frame", "Engine", "Wheels", "Doors" };
        private Dictionary<string, string> _Parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this._VehicleType = vehicleType;
        }

        //indexer
        public string this[string key]
        {
            get { return _Parts[key]; }
            set { _Parts[key] = value; }
        }

        public List<string> Show()
        {
            List<string> list = new List<string>();

            list.Add(_VehicleType);
            list.Add(_Parts[_PartsType[0]]);
            list.Add(_Parts[_PartsType[1]]);
            list.Add(_Parts[_PartsType[2]]);
            list.Add(_Parts[_PartsType[3]]);

            return list;
        }

    }
}
