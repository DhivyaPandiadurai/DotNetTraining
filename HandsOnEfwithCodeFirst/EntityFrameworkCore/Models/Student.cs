using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkCore.Models
{
    [Table("Student1")]
    class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public int?Age { get; set; }
        [Column("Std",TypeName = "varchar(16)")]
       
        //public string Class { get; set; }
        //[Column(TypeName="char(30)")]
      
        public string School { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? joinDate { get; set; }

    }
}
