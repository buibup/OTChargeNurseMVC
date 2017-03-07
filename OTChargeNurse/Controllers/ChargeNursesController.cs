using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OTChargeNurse.Context;
using OTChargeNurse.Models;

namespace OTChargeNurse.Controllers
{
    public class ChargeNursesController : Controller
    {
        private ChargeNurseContext db = new ChargeNurseContext();

        // GET: ChargeNurses
        public ActionResult Index()
        {
            var chargeNurses = db.ChargeNurses.Include(c => c.Other).Include(c => c.RiskCase);
            return View(chargeNurses.ToList());
        }

        // GET: ChargeNurses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeNurse chargeNurse = db.ChargeNurses.Find(id);
            if (chargeNurse == null)
            {
                return HttpNotFound();
            }
            return View(chargeNurse);
        }

        // GET: ChargeNurses/Create
        public ActionResult Create()
        {
            ViewBag.ChargeNurseId = new SelectList(db.Other, "OtherId", "OtherId");
            ViewBag.ChargeNurseId = new SelectList(db.RiskCases, "RiskCaseId", "RiskCaseId");
            return View();
        }

        // POST: ChargeNurses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ChargeNurseId,TotalCase,Incharge,AddDate")] ChargeNurse chargeNurse)
        {
            if (ModelState.IsValid)
            {
                db.ChargeNurses.Add(chargeNurse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ChargeNurseId = new SelectList(db.Other, "OtherId", "OtherId", chargeNurse.ChargeNurseId);
            ViewBag.ChargeNurseId = new SelectList(db.RiskCases, "RiskCaseId", "RiskCaseId", chargeNurse.ChargeNurseId);
            return View(chargeNurse);
        }

        // GET: ChargeNurses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeNurse chargeNurse = db.ChargeNurses.Find(id);
            if (chargeNurse == null)
            {
                return HttpNotFound();
            }
            ViewBag.ChargeNurseId = new SelectList(db.Other, "OtherId", "OtherId", chargeNurse.ChargeNurseId);
            ViewBag.ChargeNurseId = new SelectList(db.RiskCases, "RiskCaseId", "RiskCaseId", chargeNurse.ChargeNurseId);
            return View(chargeNurse);
        }

        // POST: ChargeNurses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ChargeNurseId,TotalCase,Incharge,AddDate")] ChargeNurse chargeNurse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chargeNurse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ChargeNurseId = new SelectList(db.Other, "OtherId", "OtherId", chargeNurse.ChargeNurseId);
            ViewBag.ChargeNurseId = new SelectList(db.RiskCases, "RiskCaseId", "RiskCaseId", chargeNurse.ChargeNurseId);
            return View(chargeNurse);
        }

        // GET: ChargeNurses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChargeNurse chargeNurse = db.ChargeNurses.Find(id);
            if (chargeNurse == null)
            {
                return HttpNotFound();
            }
            return View(chargeNurse);
        }

        // POST: ChargeNurses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChargeNurse chargeNurse = db.ChargeNurses.Find(id);
            db.ChargeNurses.Remove(chargeNurse);
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
