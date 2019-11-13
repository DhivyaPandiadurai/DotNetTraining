using OrderProject.Context;
using OrderProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderProject.Repository
{
     class OrderRepository
    {
       
            private OrderContext _context;
            public OrderRepository(OrderContext context)
            {
                _context = context;
            }
            public void Add(Order item)
            {
                using (OrderContext db = new OrderContext())
                {
                    db.Add(item);
                    db.SaveChanges();
                }
            }
            //Get all the records
            public IEnumerable<Order> GetAll()
            {
                return _context.Orders;
            }
            //Get by ID
            public Order GetById(object id)
            {
                return _context.Orders.Find(id);
            }
            //delete Students by id
            //public void delete(int id)
            //{
            //    var obj = _context.Students.Find(id);
            //    _context.Students.Remove(obj);
            //    _context.SaveChanges();

            //}
            public void update(Order item)
            {
                var obj = _context.Orders.Find(item.Orderid);
            
            obj.DDate = item.DDate;
            _context.SaveChanges();

            }
        }



    }

