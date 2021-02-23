using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIs.Models
{
   public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double CostInCredits { get; set; }
        public double Length { get; set; }
        public int Crew { get; set; }
        public DateTime Created { get; set; }

    }
}
