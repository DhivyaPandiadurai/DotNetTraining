using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Repositories
{
    public class EmployeeRepository
    {
        List<Employee> employees;
        public EmployeeRepository()
        {


           employees = new List<Employee>(){
            new Employee() { Eid=1,Ename="Pikachu",JoiningDate=DateTime.Parse("11-11-2011"),Designation="Senior Executive",Salary=120000},
             new Employee() { Eid=2,Ename="Dragon Tales",JoiningDate=DateTime.Parse("11-11-2012"),Designation="PAT",Salary=130000},
              new Employee() { Eid=3,Ename="Noddy",JoiningDate=DateTime.Parse("11-11-2013"),Designation="PAT",Salary=1400000},
               new Employee() { Eid=4,Ename="Oswald:the Octopus",JoiningDate=DateTime.Parse("11-11-2014"),Designation="PAT",Salary=150000},
            };
        }
        //Get all students
        public List<Employee> GetAll()
        {
            return employees;
        }
        //Get students by id
        public Employee GetById(int id)
        {
            return employees.SingleOrDefault(i => i.Eid == id);//lamda expression
            //return (from i in students where i.sid==id select i)
        }

        public List<Employee> GetBySalary(int salary)
        {
            return employees.Where(i => i.Salary== salary).ToList();
        }

        public List<Employee> GetByDesignation(string designation)
        {
            return employees.Where(i => i.Designation.Equals(designation)).ToList();
        }
        //Add new student details
        public void Add(Employee item)
        {
            employees.Add(item);
        }

    }
}

