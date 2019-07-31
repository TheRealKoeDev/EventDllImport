﻿using TestLibrary;
using KoeLib.ModularServices;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IModularService<ITestServiceInterface> Service;

        public ValuesController(IModularService<ITestServiceInterface> service)
        {
            Service = service;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Service.Service.CreatedAt.ToString("HH:mm:ss");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}