using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODTrainingService.Models;
using MODTrainingService.Context;
using MODTrainingService.Repository;

namespace MODTrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepo _repository;

        public TrainingController(ITrainingRepo repository)
        {
            _repository = repository;
        }
        // GET: api/Training/GetAllTraining
        [HttpGet]
        [Route("GetAllTraining")]
        public List<Training> Get()
        {
            return _repository.GetAllTraining();
        }

        // GET: api/Training/GetTrainingById
        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingById/{id}")]
        public Training Get(int id)
        {
            return _repository.GetTrainingById(id);
        }

        //GET: api/Training/GetTrainingByUserId
        [HttpGet("{id}", Name = "GetTUserId")]
        [Route("GetTrainingByUserId/{id}")]
        public List<Training> GetTUserId(int id)
        {
            return _repository.GetTrainingByUserId(id);
        }

        //GET: api/Training/GetTrainingByMentorId
        [HttpGet("{id}", Name = "GetTMentorId")]
        [Route("GetTrainingByMentorId/{id}")]
        public List<Training> GetTMentorId(int id)
        {
            return _repository.GetTrainingByMentorId(id);
        }

        // POST: api/Training/AddTraining
        [HttpPost]
        [Route("AddTraining")]
        public IActionResult Post([FromBody] Training item)
        {
            _repository.AddTraining(item);
            return Ok();
        }

        // PUT: api/Training/UpdateTraining
        [HttpPut("{id}")]
        [Route("UpdateTraining/{id}")]
        public IActionResult Put(Training item)
        {
            _repository.UpdateTraining(item);
            return Ok();

        }

        // DELETE: api/Training/DeleteTraining
        [HttpDelete("{id}")]
        [Route("DeleteTraining/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteTraining(id);
            return Ok();
        }
    }
}
