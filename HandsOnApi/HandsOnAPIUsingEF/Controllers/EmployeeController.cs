using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Models;
using HandsOnAPIUsingEF.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
        
    {
        private readonly IEmployeeRepository _repository;




        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Employee/GetAll
        [HttpGet]
        [Route("GetAll")]
        public List<Employee> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public Employee Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Employee
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Employee item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        [Route("update/{id}")]
        public void Put(int id, [FromBody] Employee item)
        {
            _repository.update(item);
            //return Ok("Record Added");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.delete(id);
        }
    }
}
