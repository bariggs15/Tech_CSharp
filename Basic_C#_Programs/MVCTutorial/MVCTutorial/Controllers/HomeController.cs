﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\arigg\Logs\log.txt", text);

            //Random random1 = new Random(10);
            //var num = random1.Next();

            ////ViewBag.RandomNumber = num;

            //if (num > 20000)
            //{
            //    return View("About");
            //}



            //return Content("hello");



            //return RedirectToAction("contact");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}