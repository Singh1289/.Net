using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationExample
{
    [Serializable]
    internal class Vehicle
    {
        public int VehicleId { get; set; }
        public string Type { get; set; }
        public int NoOfSeats { get; set; }

    }
}
