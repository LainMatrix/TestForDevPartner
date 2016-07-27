using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Abstract
{
    public    interface IRepository
    {
     IEnumerable<Order> Orders { get; }
    IEnumerable<Customer> Customers { get; }
    }
}
