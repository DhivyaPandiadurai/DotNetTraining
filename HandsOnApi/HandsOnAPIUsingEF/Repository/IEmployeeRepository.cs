using HandsOnAPIUsingEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIUsingEF.Repository
{
    public interface IEmployeeRepository
    {

        void Add(Employee item);
        List<Employee> GetAll();
        Employee GetById(int id);
        void update(Employee item);
        void delete(int id);
    }
}
