using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HotelManagmentSystem.Models;
using HotelModel.Models;

namespace HotelManagmentSystem.Controllers
{
    public class CheckOutsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CheckOuts
        public ActionResult Index()
        {
            var checkOuts = db.CheckOuts.Include(c => c.CheckIn).Include(c => c.Customer).Include(c => c.Room);
            return View(checkOuts.ToList());
        }

        // GET: CheckOuts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckOut checkOut = db.CheckOuts.Find(id);
            if (checkOut == null)
            {
                return HttpNotFound();
            }
            return View(checkOut);
        }

        // GET: CheckOuts/Create
        public ActionResult Create()
        {
            ViewBag.CheckInId = new SelectList(db.CheckIns, "Id", "Id");
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FirstName");
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "RoomInfo");
            return View();
        }

        // POST: CheckOuts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CheckOutDate,CheckInId,RoomId,CustomerId,NoAdults,NoChildren,PassportNo")] CheckOut checkOut)
        {
            if (ModelState.IsValid)
            {
                db.CheckOuts.Add(checkOut);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CheckInId = new SelectList(db.CheckIns, "Id", "Id", checkOut.CheckInId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FirstName", checkOut.CustomerId);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "RoomInfo", checkOut.RoomId);
            return View(checkOut);
        }

        // GET: CheckOuts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckOut checkOut = db.CheckOuts.Find(id);
            if (checkOut == null)
            {
                return HttpNotFound();
            }
            ViewBag.CheckInId = new SelectList(db.CheckIns, "Id", "Id", checkOut.CheckInId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FirstName", checkOut.CustomerId);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "RoomInfo", checkOut.RoomId);
            return View(checkOut);
        }

        // POST: CheckOuts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CheckOutDate,CheckInId,RoomId,CustomerId,NoAdults,NoChildren,PassportNo")] CheckOut checkOut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(checkOut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CheckInId = new SelectList(db.CheckIns, "Id", "Id", checkOut.CheckInId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FirstName", checkOut.CustomerId);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "RoomInfo", checkOut.RoomId);
            return View(checkOut);
        }

        // GET: CheckOuts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CheckOut checkOut = db.CheckOuts.Find(id);
            if (checkOut == null)
            {
                return HttpNotFound();
            }
            return View(checkOut);
        }

        // POST: CheckOuts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CheckOut checkOut = db.CheckOuts.Find(id);
            db.CheckOuts.Remove(checkOut);
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
