using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderProject.Models
{
    [Table("Item")]
    class Item
    {
        [Key]
        public int Iid { get; set; }
        public string Iname { get; set; }
        public int Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
