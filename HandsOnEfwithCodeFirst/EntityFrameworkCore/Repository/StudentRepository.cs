using System;
using System.Collections.Generic;
using System.Text;
using EntityFrameworkCore.Context;
using EntityFrameworkCore.Models;

namespace EntityFrameworkCore.Repository
{
    class StudentRepository
    {
        private StudentContext _context;
        public StudentRepository(StudentContext context)
        {
            _context = context;
        }
        public void Add(Student item)
        {
            using (StudentContext db =new StudentContext())
            {
                db.Add(item);
                db.SaveChanges();
            }
        }
        //Get all the records
        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }
        //Get by ID
        public Student GetById(object id)
        {
            return _context.Students.Find(id);
        }
        //delete Students by id
        //public void delete(int id)
        //{
        //    var obj = _context.Students.Find(id);
        //    _context.Students.Remove(obj);
        //    _context.SaveChanges();

        //}
        public void update(Student item)
        {
            var obj = _context.Students.Find(item.ID);
            obj.School = item.School;
            obj.Age = item.Age;
            obj.Class = item.Class;
            _context.SaveChanges();

        }
    }
}
