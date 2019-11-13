using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkCore.Models
{ 
    [Table("Dept")]
    class Dept
    {
        [Key]
        public string Did { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string DName { get; set; }
        public ICollection<Employee> Employees { get; set; }//ICollection-one to many relation

    }
}
