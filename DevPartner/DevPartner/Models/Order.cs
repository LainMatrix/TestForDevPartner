﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevPartner.Models
{
    public class Order
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }

        public string Description { get; set; }
    }
}