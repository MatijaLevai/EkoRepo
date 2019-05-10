using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Addres
    {
        public string StreetName { get; set; }
        public string BuildingNumber { get; set; }
        public int AppartmentNumber { get; set; }
        public int FloorNumber { get; set; }
    }
}
