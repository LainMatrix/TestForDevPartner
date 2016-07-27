using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
  public  class EFRepository :IRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Entities.Order> Orders
        {
            get { return context.Orders; }
        }

        public IEnumerable<Entities.Customer> Customers
        {
            get { return context.Customers; }
        }
    }
}
