using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeService.Models;
using EmployeeService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository repository = new EmployeeRepository();
        // GET: api/Employee
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repository.GetAll());
        }

        // GET: api/Employee/5
        [Route("Getid/{id}")]
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(repository.GetById(id));
        }
        [Route("GetSalary/{salary}")]
        [HttpGet("{salary}", Name = "Getsalary")]
        public IActionResult Getsalary(int salary)
        {
            return Ok(repository.GetBySalary(salary));
        }

        [Route("GetDesignation/{designation}")]
        [HttpGet("{designation}", Name = "Getdesignation")]
        public IActionResult Getdesignation(string designation)
        {
            return Ok(repository.GetByDesignation(designation));
        }
        // POST: api/Employee
        [HttpPost]
        public void Post(Employee item)
        {
            repository.Add(item);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
