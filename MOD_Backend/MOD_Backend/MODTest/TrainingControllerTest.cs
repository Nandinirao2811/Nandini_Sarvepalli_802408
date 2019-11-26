using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MODTrainingService.Models;
using MODTrainingService.Controllers;
using MODTrainingService.Repository;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MODTest
{
   public class TrainingControllerTest
    {
        private readonly Mock<ITrainingRepo> _repo;
        private readonly TrainingController _controller;
        public TrainingControllerTest()
        {
            _repo = new Mock<ITrainingRepo>();
            _controller = new TrainingController(_repo.Object);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAllTraining()).Returns(GetTrainings());
            var result = _controller.Get() as List<Training>;
            Assert.Equal(3, result.Count);

        }
        [Fact]
        public void GetByID()
        {
            _repo.Setup(m => m.GetTrainingById(1)).Returns(GetTrainings()[0]);
            var result = _controller.Get(1) as Training;
            Assert.NotNull(result);
            Assert.Equal(1, result.Training_Id);
        }

        [Fact]
        public void Post()
        {
            var item = GetTrainings()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Update()
        {
            var item = GetTrainings()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.DeleteTraining(It.IsAny<int>()));
            var result = _controller.Delete(1) as OkResult;
            Assert.NotNull(result);
        }
        private List<Training> GetTrainings()
        {
            return new List<Training>()
            {
                new Training() {Training_Id=1, Training_Progress="Ongoing"},
                new Training() {Training_Id=2, Training_Progress="Ongoing5"},
                new Training() {Training_Id=3, Training_Progress="Ongoing4"},

            };
        }
    }
}
