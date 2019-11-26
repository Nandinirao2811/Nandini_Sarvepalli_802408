using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODPaymentService.Context;
using MODPaymentService.Models;
namespace MODPaymentService.Repositories
{
    public interface IPaymentRepository
    {
        List<Payment> GetAllPayments();
        void AddPayment(Payment item);
    }
}
