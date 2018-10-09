using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class CustomerOrderController : Controller
    {
        private huseyinEntities2 db = new huseyinEntities2();
        // GET: CustomerOrader
        public ActionResult Index()
        {
            List<Customer> customerlist = db.Customers.ToList();
            List<Order> orederlist = db.Orders.ToList();
            List<Order_Detail> odlist = db.Order_Details.ToList();

            return View();
        }
    }
}