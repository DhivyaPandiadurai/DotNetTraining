using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.PaymentService.Context;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }
        public void AddPaymentDetails(Payment item)
        {
            _context.payments.Add(item);
            _context.SaveChanges();
        }
    }
}
