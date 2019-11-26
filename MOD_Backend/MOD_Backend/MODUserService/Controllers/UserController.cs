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
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        // GET: api/User/
        [HttpGet]
        [Route("GetAllUsers")]
        public List<User> Get()
        {
            return _repository.GetAllUsers();
        }

        // GET: api/User/GetUserById
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetUserById/{id}")]
        public User Get(int id)
        {
            return _repository.GetUserById(id);
        }

        // GET: api/User/GetMentorSearch
        [HttpGet]
        [Route("GetMentorSearch/{skill}/{fromTimeslot}/{toTimeslot}")]
        public List<Mentor> Get(string skill, string fromTimeslot, string toTimeslot)
        {
            return _repository.GetMentorSearch(skill, fromTimeslot, toTimeslot);

        }


        // POST: api/User/AddUser
        [HttpPost]
        [Route("AddUser")]
        public IActionResult Post([FromBody] User item)
        {
            _repository.AddUser(item);
            return Ok();
        }

        // PUT: api/User/UpdatePassword
        [HttpPut("{id}")]
        [Route("UpdateUserPassword/{Useremail}/{Userpassword}")]
        public void Put(string Useremail, string Userpassword)
        {
            _repository.UpdateUserPassword(Useremail,Userpassword);
        }

        // PUT: api/User/BlockUser
        [HttpPut("{id}")]
        [Route("BlockUser/{id}")]
        public void Put(int id)
        {
            _repository.BlockUser(id);
        }

        // DELETE: api/User/DeleteUser
        [HttpDelete("{id}")]
        [Route("DeleteUser/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteUser(id);
            return Ok();
        }
    }
}
