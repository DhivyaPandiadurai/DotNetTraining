using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Context;
using HandsOnAPIUsingEF.Models;

namespace HandsOnAPIUsingEF.Repository
{
    
        public class EmployeeRepository : IEmployeeRepository
        {
        private readonly EmployeeCOntext _context;
        public EmployeeRepository(EmployeeCOntext context)
        {
            _context = context;
        }
            public void Add(Employee item)
            {
            _context.employees.Add(item);
            _context.SaveChanges();
            }

            public void delete(int id)
            {
            var item = _context.employees.Find(id);
            _context.employees.Remove(item);
            _context.SaveChanges();

            }

            public List<Employee> GetAll()
            {
            return _context.employees.ToList();
        }

            public Employee GetById(int id)
            {
            return _context.employees.Find(id);

            }

            public void update(Employee item)
            {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            }
        }
    }

