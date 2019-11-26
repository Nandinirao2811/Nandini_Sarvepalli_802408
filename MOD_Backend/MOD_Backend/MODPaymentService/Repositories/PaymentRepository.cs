using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODPaymentService.Models;
using MODPaymentService.Context;

namespace MODPaymentService.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }

        public void AddPayment(Payment item)
        {
            try
            {
                _context.Payments.Add(item);
                _context.SaveChanges();
            }
         
              catch (Exception)
            {
                throw;
            }
        }
       
        public List<Payment> GetAllPayments()
        {
            try
            {
                return _context.Payments.ToList();
            }
          
              catch (Exception)
            {
                throw;
            }
        }
    }
}
