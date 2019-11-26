using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODTechnologyService.Context;
using MODTechnologyService.Repositories;
using MODTechnologyService.Models;

namespace MODTechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyRepository _repository;
        
        public TechnologyController(ITechnologyRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Technology/GetAllTechnology
        [HttpGet]
        [Route("GetAllTechnology")]
        public List<Technology> Get()
        {
            return _repository.GetAllTechnology();
        }

        //// GET: api/Technology/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Technology/AddTechnology
        [HttpPost]
        [Route("AddTechnology")]
        public IActionResult Post([FromBody] Technology item)
        {
            _repository.AddTechnology(item);
            return Ok();
        }

        // PUT: api/Technology/UpdateTechnology/1
        [HttpPut("{id}")]
        [Route("UpdateTechnology/{id}")]
        public IActionResult Put(Technology item)
        {
            _repository.UpdateTechnology(item);
            return Ok();
        }

        // DELETE: api/Technology/DeleteTechnology
        [HttpDelete("{id}")]
        [Route("DeleteTechnology/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteTechnology(id);
            return Ok();
        }
    }
}
