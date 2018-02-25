using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingFeedback.Models
{
    public class Permit
    {
        [Key]
        public int ProjectID { get; set; }

        public int BuildingID { get; set; }
        public virtual Building Building { get; set; }
        public virtual Effects Effect{get; set;}

    }
}
