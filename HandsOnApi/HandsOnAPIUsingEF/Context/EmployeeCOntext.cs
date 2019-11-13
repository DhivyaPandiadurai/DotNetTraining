using HandsOnAPIUsingEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIUsingEF.Context
{
    public class EmployeeCOntext:DbContext
       
    {
        public EmployeeCOntext(DbContextOptions<EmployeeCOntext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-J33QLHE\SQLDB;Database=EmpDB;Trusted_Connection=True;");
        //}

            public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }

    
}
