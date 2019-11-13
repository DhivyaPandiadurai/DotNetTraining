using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkCore.Models
{
    [Table("Employee")]
    class Employee
    {
        [Key]
        public int Eid { get; set; }
        [Required]
        public string Ename { get; set; }
        [Column("Designation",TypeName="varchar(30)")]
        public string Desig { get; set; }
        [Column("Salary")]
        public int? Sal { get; set; }
       [ForeignKey("Dept")]
        public string Did { get; set; }
        public Dept Dept { get; set; }//since one to many
         //many to many collection-public ICollection<Dept> Dept{get;set;}

    }

}
//POCO-Plaon Old CLR Object