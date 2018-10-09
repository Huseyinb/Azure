using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class CustomerOrders
    {

        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }


    }
}