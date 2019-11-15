using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public long Pid { get; set; }

        public long Uid { get; set; }

        public double amount { get; set; }

        public long Mid { get; set; }

        public double Mentor_Amount { get; set; }

    }
}
