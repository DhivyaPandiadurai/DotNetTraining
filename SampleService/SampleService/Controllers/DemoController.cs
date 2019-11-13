using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        //public string Get()
        //{
        //    return "Hello World";
        //}
        //public List<string> Get()
        //{
        //    return new List<string> {"kani","D" };
        //}
        //public IActionResult Get()
        //{
        //    return Ok(new List<string> {"Jenny","Navya","Sherii"});
        //}
        public IActionResult Get(string id)//-api/demo?id=name
        {
            string s = "hello" + id;
            return Ok(s);
        }
        [Route("{no:int}")]
        public IActionResult Get(int i)// -/api/demo/24
        {
            return Ok("return no's ");
        }
        public IActionResult Post(object item)
        {
            return Ok("Resource added...");
        }
        public IActionResult Put(int id)
        {
            return Ok("resource updated");
        }
        public IActionResult Delete(int id)
        {
            return Ok("resource deleted");
        }
    }
}