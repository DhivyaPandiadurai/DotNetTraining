﻿using OrderProject.Context;
using OrderProject.Models;
using OrderProject.Repository;
using System;

namespace OrderProject
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderContext context = new OrderContext();
            OrderRepository repository = new OrderRepository(context);
            try
            {
                //Order obj = new Order()
                //{
                   
                //    ODate = DateTime.Now,
                //    DDate = DateTime.Now.AddDays(7)
                //    //Age = 10,
                //    //// Class = "II",
                //    //School = "Abc",
                //    //joinDate = DateTime.Parse("11-12-2014")
                //};
                //repository.Add(obj);

            }

            //Student obj = repository.GetById(1);
            //if (obj != null)
            //{
            //    Console.WriteLine("{0} {1}", obj.Name, obj.Class);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid ID");
            //}
            ////check delete
            ////repository.delete(1);
            ////check update
            //Student obj1 = repository.GetById(1);
            //obj1.Age = 12;
            //repository.update(obj1);

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
    }
    }
}
