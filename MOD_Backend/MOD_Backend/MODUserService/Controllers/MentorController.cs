using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODUserService.Context;
using MODUserService.Models;
using MODUserService.Repositories;

namespace MODUserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Mentor/GetAllMentors
        [HttpGet]
        [Route("GetAllMentors")]
        public List<Mentor> Get()
        {
            return _repository.GetAllMentors();
        }

        // GET: api/Mentor/5
       // [HttpGet("{id}", Name = "Get")]
        [Route("GetMentorById/{id}")]
        public Mentor Get(int id)
        {
            return _repository.GetMentorById(id);
        }

        // POST: api/Mentor/AddMentor
        [HttpPost]
        [Route("AddMentor")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.AddMentor(item);
            return Ok("Mentor Record Added");
        }

        // PUT: api/Mentor/UpdateMentor/1
        [HttpPut("{id}")]
        [Route("UpdateMentorPassword/{Mentoremail}/{Mentorpassword}")]
        public void Put(string Mentoremail, string Mentorpassword)
        {
            _repository.UpdateMentorPassword(Mentoremail, Mentorpassword);
        }

        // DELETE: api/Mentor/DeleteMentor/2
        [HttpDelete("{id}")]
        [Route("DeleteMentor/{id}")]
        public void Delete(int id)
        {
            _repository.DeleteMentor(id);
        }
        // PUT: api/Mentor/BlockMentor
        [HttpPut("{id}")]
        [Route("BlockMentor/{id}")]
        public void Put(int id)
        {
            _repository.BlockMentor(id);
        }
    }
}
