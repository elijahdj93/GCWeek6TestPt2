using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week6TestPt2.Models;

namespace Week6TestPt2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            NorthwindEntities ORM = new NorthwindEntities();//ORM
            List<Order> OrderList = ORM.Orders.ToList();// select * from orders

            ViewBag.Message = "Your application description page.";
            ViewBag.Olist = OrderList;//sending the list of customers to the view

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}