using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MODUserService.Models;
using MODUserService.Repositories;
using MODUserService.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MODTest
{
   public  class UserControllerTest
    {
        private readonly Mock<IUserRepository> _repo;
        private readonly UserController _controller;
        public UserControllerTest()
        {
            _repo = new Mock<IUserRepository>();
            _controller = new UserController(_repo.Object);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAllUsers()).Returns(GetUsers());
            var result = _controller.Get() as List<User>;
            Assert.Equal(3, result.Count);
        }
        [Fact]
        public void GetByID()
        {
            _repo.Setup(m => m.GetUserById(1)).Returns(GetUsers()[0]);
            var result = _controller.Get(1) as User;
            Assert.NotNull(result);
            Assert.Equal(1, result.User_Id);
        }

        [Fact]
        public void Post()
        {
            var item = GetUsers()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.DeleteUser(It.IsAny<int>()));
            var result = _controller.Delete(1) as OkResult;
            Assert.NotNull(result);
        }

        private List<User> GetUsers()
        {
            return new List<User>()
            {
                new User() {User_Id=1, User_Name="nandini"},
                 new User() {User_Id=2, User_Name="nandini2"},
                  new User() {User_Id=3, User_Name="nandini3"}

            };
        }
    }
}
