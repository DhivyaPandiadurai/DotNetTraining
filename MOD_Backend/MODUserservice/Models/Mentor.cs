using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MODUserservice.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        public long Mid { get; set; }

        public string Mname { get; set; }

        public long Mobile { get; set; }

        public string Email { get; set; }

        public string exp { get; set; }

        public string Primary_skill { get; set; }

        public string timeslot { get; set; }

public bool availability { get; set; }

        public bool Active { get; set; }

    }
}
