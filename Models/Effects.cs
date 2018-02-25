using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingFeedback.Models
{
    public class Effects
    {
        [Key]
        public string CondUse { get; set; }
        public string Noise { get; set; }
        public string Environment { get; set; }
    }
}
