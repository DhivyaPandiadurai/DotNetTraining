using Microsoft.EntityFrameworkCore;
using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Context
{
    public class TrainingContext : DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options) { }

        public DbSet<Training> trainings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Training>().HasData(new Training
            {
              TrainingID=1,
                UID=1234,
                MID=122,
                SkillID=345,
                StartDate=DateTime.Parse("11-2-2017"),
                EndDate=DateTime.Parse("2-2-2018"),
                timeslot="evening",
                status="Not Completed",
                Progress=25,
                rating=3.5f
            }
                );

        }

    }
}
