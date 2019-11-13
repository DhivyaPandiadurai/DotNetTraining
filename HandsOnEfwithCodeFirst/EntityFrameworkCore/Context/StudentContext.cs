using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.Models;

namespace EntityFrameworkCore.Context
{
    class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Dept> Depts { get; set; }
        public DbSet<Employee> Employees { get; set; }









        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-J33QLHE\SQLDB;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
//Server specifies the location of the Database server,Database-On which Db we want to create,Trusted Connection=True(Windows Authentication),(Second type)We should give the password and username