using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain.Concrete;
using Domain.Entities;
using Domain.Abstract;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class OrdersController : Controller
    {
        private EFDbContext db = new EFDbContext();

       

        public ActionResult Create(int? CustomerId)
        {
            if (db.Customers == null || !db.Customers.Any())
            {
                return HttpNotFound();
            }

            List<Customer> customers=new List<Customer>();
            OrdersModel model=new OrdersModel();
            if(CustomerId!=null)
            {
                 customers.Add(db.Customers.Find(CustomerId));
                if (customers == null || !customers.Any())
                {
                    return HttpNotFound();
                }
             
            }
            
            else
            {
             customers=db.Customers.ToList();
            }
          foreach (var cust in customers)
{
          model.Customers.Add(new SelectListItem()
               {
              Text=cust.Name,
               Value = cust.CustomerId.ToString()
               });
              
}
            return View(model);
        }
     

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrdersModel order)
        {
           
            if (ModelState.IsValid)
            {
                Order adder = new Order() { Amount = order.Amount, Date = order.Date, Description = order.Description };
                    adder.Customer=db.Customers.Find(order.CustomerId);
               
                db.Orders.Add(adder);
                db.SaveChanges();
                return RedirectToAction("list","Report");
            }

            return View(order);
        }

      
        public ActionResult Edit(int? id)
        {
            

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Where(o => o.Number == id).Include(o => o.Customer).First();
            if (order == null)
            {
                return HttpNotFound();
            }

            OrdersModel model = new OrdersModel() { Date =order.Date, Amount = order.Amount, CustomerId = order.Customer.CustomerId, Description = order.Description,Number=order.Number };
            TempData["order"] = order;

            return View(model);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Number,Date,Amount,Description")] OrdersModel order)
        {

            if (ModelState.IsValid)
            {
                //customer custumer = db.customers.find(order.customerid);
                //if (custumer == null)
                //{
                //    return httpnotfound();
                //}
            Order adder = (Order)TempData["order"];
                adder.Amount = order.Amount;
                adder.Date = order.Date;
                adder.Description = order.Description;

                db.Entry(adder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("list", "Report");
            }
            return View(order);
        }

 
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Where(o=>o.Number==id).Include(o => o.Customer).First();
            if (order == null)
            {
                return HttpNotFound();
            }
            OrdersModel model = new OrdersModel() { Date = order.Date, Amount = order.Amount, CustomerId = order.Customer.CustomerId, Description = order.Description, Number = order.Number };

            return View(model);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("list", "Report");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
