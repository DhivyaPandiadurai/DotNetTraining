using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODUserservice.Models;
using MODUserservice.Repository;

namespace MODUserservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //[HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public User Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/User
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] User item)
        {
            _repository.AddUser(item);
            return Ok("Record Added");
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Route("Update/")]

        public IActionResult Put(User item)
        {
            _repository.UpdatePassword(item);
            return Ok("Record updated");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.DeleteUser(id);
        }
        public void Block(int id)
        {
            _repository.BlockUser(id);
        }

        [HttpGet]
        [Route("GetMentor/{id}")]
        public List<Mentor> Get(String id)
        {
            return _repository.SearchMentor(id);
        }
    }
}
