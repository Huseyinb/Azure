using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class CustomerOrderController : Controller
    {

        private huseyinEntities2 db = new huseyinEntities2();
        // GET: CustomerOrder
        public ActionResult Index()
        {
            var query = from c in db.Customers join o in db.Orders on c.CustomerID equals o.CustomerID join od in db.Order_Details on o.OrderID equals od.OrderID select new CustomerOrders { CompanyName = c.CompanyName, ContactName = c.ContactName, Product = od.Product, UnitPrice = od.UnitPrice };


            return View(query.ToList());
        }
    }
}