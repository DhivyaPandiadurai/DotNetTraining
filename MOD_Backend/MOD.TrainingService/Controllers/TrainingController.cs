﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repository;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;




        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Training
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Training/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Training
        [HttpPost]
        [Route("AddTraining")]
        public IActionResult Post([FromBody] Training item)
        {
            _repository.AddTraining(item);
            return Ok("Record Added");
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("UpdateTraining/{id}")]
        public IActionResult Put(int id, [FromBody] Training item)
        {
            _repository.UpdateTraining(item);
            return Ok("Record Updated");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}