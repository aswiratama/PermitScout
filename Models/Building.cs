using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingFeedback.Models
{
    public class Building
    {
        [Key]
        public int Storeys { get; set; }
        public int ParkingLots { get; set; }
        public int Capacity { get; set; }
        public string Use { get; set; }
        public string Address { get; set; }
        public int ZIPCode { get; set; }
    }
}
