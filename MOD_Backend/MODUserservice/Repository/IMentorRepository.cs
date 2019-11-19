using MODUserservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODUserservice.Repository
{
    public interface IMentorRepository
    {
        void AddMentor(Mentor item);
        Mentor GetMentorById(int id);
        void BlockMentor(int id);
        void UpdateMentor(Mentor item);
        void DeleteMentor(long id);
    }
}
