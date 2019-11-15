using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Models
{
    [Table("Training")]
    public class Training
    {
        public long TrainingID { get; set; }

        public long UID {get;set;}

        public long MID { get; set; }

        public long SkillID { get; set; }

        public DateTime StartDate { get; set; }

         public DateTime EndDate { get; set; }

        public string timeslot { get; set; }

        public string status { get; set; }

        public long Progress { get; set; }

        public float rating { get; set; }

    }

}

