using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 
using Domain.Concrete;
using Domain.Entities;

namespace WebUI.Infrastructure
{
    public class BdInitialiser : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {

            Customer cust1 =new Customer() { Name = "Alex", Address = "Halturina 50" };
            Customer cust2=new Customer() { Name = "Александр", Address = "Халтурина 50"};
            Customer cust3=new Customer() { Name = "Алексей", Address = "Хмельницкого 35"};
            Customer cust4=new Customer() { Name = "Gleb", Address = "Gagarina 50" };

            context.Customers.Add(cust1);
            context.Customers.Add(cust2 );
            context.Customers.Add(cust3 );
            context.Customers.Add(cust4);


            context.Orders.Add(new Order() { Date = new DateTime(2008, 6, 15), Amount = 5, Description = "Какое-то описание ", Customer = cust1});
            context.Orders.Add(new Order() { Date = new DateTime(2011, 4, 1), Amount = 20, Description = "Какое-то описание ", Customer = cust2 });
            context.Orders.Add(new Order() { Date = new DateTime(2005, 4, 22), Amount = 5, Description = "Какое-то описание ", Customer = cust3 });
            context.Orders.Add(new Order() { Date = new DateTime(2006, 5, 26), Amount = 7, Description = "Какое-то описание ", Customer = cust4 });
            context.Orders.Add(new Order() { Date = new DateTime(2004, 7,16), Amount = 9, Description = "Какое-то описание ", Customer = cust2 });
            context.Orders.Add(new Order() { Date = new DateTime(2003, 2, 4), Amount = 5, Description = "Какое-то описание ", Customer = cust3 });
            context.Orders.Add(new Order() { Date = new DateTime(2012, 4, 8), Amount = 7, Description = "Какое-то описание ", Customer = cust4 });
            context.Orders.Add(new Order() { Date = new DateTime(2016, 6,6), Amount = 9, Description = "Какое-то описание ", Customer = cust1 });
            context.Orders.Add(new Order() { Date = new DateTime(2000,7, 8), Amount = 15, Description = "Какое-то описание ", Customer = cust4 });
            context.Orders.Add(new Order() { Date = new DateTime(2015, 8, 9), Amount = 67, Description = "Какое-то описание ", Customer = cust3 });

            base.Seed(context);
        }
    }
}