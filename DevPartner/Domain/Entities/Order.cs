using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Order
    {
        [Key]
        public int Number { get; set; }



       
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


     
        public int Amount { get; set; }


           [UIHint("MultilineText")]
        public string Description { get; set; }
   
        [Required]
        public Customer Customer { get; set; }
        

    }
}