using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                int base1 = 50;
                int runningTotal = Convert.ToInt32(insuree.Quote());
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year; 
                
                if (age <= 18)
                {
                    int younger = base1 + 100 ;
                    return View(insuree);
                }
                else if (age >19 && age < 25)
                {
                    int medium = base1 + 50;
                    return View(insuree);
                }
                else
                {
                    int older = base1 + 25;
                    return View(insuree);
                }


                int carYear = insuree.CarYear;

                if (carYear < 2000)
                {
                    int olderCar = base1 + 25;
                    return View(insuree);
                }
                else if (carYear > 2015)
                {
                    int newCar = base1 + 25;
                    return View(insuree);
                }

                string carMake = insuree.CarMake;

                if (carMake == "Porsche")
                {
                    int porsche = base1 + 25;
                    return View(insuree);
                
                    if (carMake == "Porsche" && insuree.CarModel == "911 Carerra")
                    {
                        int porscheplus = base1 + 50;
                        return View(insuree);
                    }
                }

                int speedingTicket = insuree.SpeedingTickets;
                if (speedingTicket > 0)
                {
                    int extraSpeed = speedingTicket * 10;
                    return View(insuree);
                }

                if (insuree.DUI == true)
                {
                    insuree.Quote = runningTotal * 1.25;
                    return View(insuree);
                }
                else
                {
                    return View(insuree);
                }

                if (insuree.CoverageType == true)
                {
                    insuree.Quote = runningTotal * 1.50;
                }
                else
                {
                    return View(insuree);
                }




                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

       
    }
}
