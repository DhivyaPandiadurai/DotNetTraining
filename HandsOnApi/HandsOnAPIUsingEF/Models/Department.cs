using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIUsingEF.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public string Did { get; set; }
        [StringLength(20)]
        public string DeptName { get; set; }
    }
}
