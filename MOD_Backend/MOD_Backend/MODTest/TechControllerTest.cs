using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MODTechnologyService.Controllers;
using MODTechnologyService.Models;
using MODTechnologyService.Repositories;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MODTest
{
    public class TechControllerTest
    {
        private readonly Mock<ITechnologyRepository> _repo;
        private readonly TechnologyController _controller;
        public TechControllerTest()
        {
            _repo = new Mock<ITechnologyRepository>();
            _controller = new TechnologyController(_repo.Object);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAllTechnology()).Returns(GetTechnologies());
            var result = _controller.Get() as List<Technology>;
            Assert.Equal(3, result.Count);
        }

        //[Fact]
        //public void GetByID()
        //{
        //    _repo.SetUp(m => m.GetTechnologyById("Java")).Returns(GetTechnologies()[0]);
        //    var result = _controller.Get("Java") as Technology;
        //    Assert.NotNull(result);
        //    Assert.Equal("Java", result.Skill_Name);
        //}

        [Fact]
        public void Post()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Put()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.DeleteTechnology(It.IsAny<int>()));
            var result = _controller.Delete(1) as OkResult;
            Assert.NotNull(result);
        }


        private List<Technology> GetTechnologies()
        {
            return new List<Technology>()
            {
                new Technology() {Skill_Id=1, Skill_Name="Oracle", Skill_TOC="chap", Skill_Fees=100, Skill_Duration="4m"},
                new Technology() {Skill_Id=2, Skill_Name="Oracle1",Skill_TOC="chap", Skill_Fees=100, Skill_Duration="4m"},
                new Technology() {Skill_Id=3, Skill_Name="Oracle2",Skill_TOC="chap", Skill_Fees=100, Skill_Duration="4m"}
            };
        }
    }
}
