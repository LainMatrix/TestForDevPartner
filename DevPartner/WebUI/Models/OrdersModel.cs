using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class OrdersModel
    {
          public OrdersModel ()
     {
         Customers = new List<SelectListItem>();
      }
          [DataType(DataType.Date)]
          [Required(ErrorMessage = "Поле должно быть установлено")]   
          public DateTime Date { get; set; }

          [Required(ErrorMessage = "Поле должно быть установлено")]
          public int Amount { get; set; }


          public int CustomerId { get; set; }

          [Required(ErrorMessage = "Поле должно быть установлено")]
          [DataType(DataType.MultilineText)]
          public string Description { get; set; }

        [HiddenInput(DisplayValue=false)]
          public int Number{ get; set; }

          public IList<SelectListItem> Customers { get; set; }
    }
}