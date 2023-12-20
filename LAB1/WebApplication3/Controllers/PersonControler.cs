﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonControler : ControllerBase
    {
        // GET: api/<PersonControler>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PersonControler>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonControler>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonControler>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonControler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)


        {
        }
    }
}
