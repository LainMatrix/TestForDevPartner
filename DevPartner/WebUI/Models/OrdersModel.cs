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
        [Display(Name = "Дата")]
          [DataType(DataType.Date)]
          [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
          [Required(ErrorMessage = "Поле должно быть установлено")]   
          public DateTime Date { get; set; }

        [Range(0,Int32.MaxValue)]
        [Display(Name = "Количество")]
          [Required(ErrorMessage = "Поле должно быть установлено")]
          public int Amount { get; set; }

 
        [HiddenInput(DisplayValue = false)]
          public int CustomerId { get; set; }


          [Display(Name = "Описание")]
          [Required(ErrorMessage = "Поле должно быть установлено")]
          [DataType(DataType.MultilineText)]
          [UIHint("MultilineText")]
          public string Description { get; set; }


        [HiddenInput(DisplayValue=false)]
          public int Number{ get; set; }

          public IList<SelectListItem> Customers { get; set; }
    }
}