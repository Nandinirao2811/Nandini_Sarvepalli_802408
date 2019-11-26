using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MODPaymentService.Controllers;
using MODPaymentService.Models;
using MODPaymentService.Repositories;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MODTest
{
    public class PaymentControllerTest
    {
        private readonly Mock<IPaymentRepository> _repo;
        private readonly PaymentController _controller;
        public PaymentControllerTest()
        {
            _repo = new Mock<IPaymentRepository>();
            _controller = new PaymentController(_repo.Object); 
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAllPayments()).Returns(GetPayments());
            var result = _controller.Get() as List<Payment>;
            Assert.Equal(4, result.Count);
        }
        [Fact]
        public void Post()
        {
            var item = GetPayments()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        private List<Payment> GetPayments()
        {
            return new List<Payment>()
            {
                new Payment() {Payment_Id=1, Payment_Amount=1000},
                 new Payment() {Payment_Id=2, Payment_Amount=2000},
                  new Payment() {Payment_Id=3, Payment_Amount=3000},
                   new Payment() {Payment_Id=4, Payment_Amount=4000},

            };
        }
    }
}
