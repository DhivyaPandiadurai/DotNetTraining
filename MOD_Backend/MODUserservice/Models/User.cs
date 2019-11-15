using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MODUserservice.Models
{
    [Table("Users")]
    public class User
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long Mobile { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }


    }
}
