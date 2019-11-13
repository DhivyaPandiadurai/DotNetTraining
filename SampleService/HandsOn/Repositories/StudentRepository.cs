using HandsOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOn.Repositories
{
    public class StudentRepository
    {

        List<Student> students;
        public StudentRepository()
        {


            students = new List<Student>(){
            new Student() { sid=1,sname="Pikachu",Class="II",Age=12},
             new Student() { sid=2,sname="Dragon Tales",Class="II",Age=12},
              new Student() { sid=3,sname="Noddy",Class="II",Age=12},
               new Student() { sid=4,sname="Oswald:the Octopus",Class="II",Age=12},
            };
    }
        //Get all students
        public List<Student> GetAll()
        {
            return students;
        }
        //Get students by id
        public Student GetById(int id)
        {
            return students.SingleOrDefault(i => i.sid == id);//lamda expression
            //return (from i in students where i.sid==id select i)
        }

        public List<Student> GetByAge(int age)
        {
            return students.Where(i => i.Age == age).ToList();
        }
        //Add new student details
        public void Add(Student item)
        {
            students.Add(item);
        }

    } }
