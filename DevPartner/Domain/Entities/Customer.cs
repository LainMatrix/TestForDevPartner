using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Domain.Entities

{
    public class Customer
    {
      public int CustomerId { get; set; }


         [Required(ErrorMessage = "Поле должно быть установлено")]
      public  string Name { get; set; }

         [Required(ErrorMessage = "Поле должно быть установлено")]
       public string Address { get; set; }

        
       public List<Order> orders { get; set; }
    }
}