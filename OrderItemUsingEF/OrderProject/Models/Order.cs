using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderProject.Models
{
    [Table("Order")]

    class Order
    {
        public int Orderid { get; set; }
        [ForeignKey("Item")]
        public int Iid { get; set; }
        public Item Item{ get; set; }
        public DateTime ODate { get; set; }
        public DateTime DDate { get; set; }
    }
}
