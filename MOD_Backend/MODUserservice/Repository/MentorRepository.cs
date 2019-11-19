using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODUserservice.Context;
using MODUserservice.Models;

namespace MODUserservice.Repository
{
    public class MentorRepository : IMentorRepository
    {
        private readonly MainContext _context;
        public MentorRepository(MainContext context)
        {
            _context = context;
        }

        public void AddMentor(Mentor item)
        {
            _context.mentors.Add(item);
            _context.SaveChanges();
        }

        public void BlockMentor(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteMentor(long id)
        {
            var item = _context.mentors.Find(id);
            _context.mentors.Remove(item);
            _context.SaveChanges();
        }

        public Mentor GetMentorById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMentor(Mentor item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
