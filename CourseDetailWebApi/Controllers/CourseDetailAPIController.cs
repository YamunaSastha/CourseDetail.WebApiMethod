using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseDetailWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseDetailAPIController : ControllerBase
    {
       private readonly ICourseDetailsRepository obj;

        public CourseDetailAPIController()
        {
            obj = new CourseDetailsRepository();
        }
    
        // GET: api/<CourseDetailAPIController>
        [HttpGet]
        public IEnumerable<CourseDetails> Get()
        {
            return obj.ReadSP();
        }

        // GET api/<CourseDetailAPIController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
          //  return "value";
        //}

        // POST api/<CourseDetailAPIController>
        [HttpPost]
        public void Post([FromBody] CourseDetails value)
        {
            obj.InsertSP(value);
        }

        // PUT api/<CourseDetailAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CourseDetails value)
        {
            obj.UpdateSP(id,value);
        }

        // DELETE api/<CourseDetailAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            obj.DeleteSP(id);
        }
    }
}
