using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOn.Models;
using HandsOn.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentRepository repository = new StudentRepository();
        // GET: api/Student
        [HttpGet]
        public IActionResult Get()

        {
            return Ok(repository.GetAll());
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(repository.GetById(id));
        }

        // POST: api/Student
        [HttpPost]
        public void Post(Student item)
        {
            repository.Add(item);
        }

        // PUT: api/Student/5
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
