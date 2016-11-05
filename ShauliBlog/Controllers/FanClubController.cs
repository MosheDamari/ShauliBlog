using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShauliBlog.DAL;
using ShauliBlog.Models;

namespace ShauliBlog.Controllers
{
    public class FanClubController : Controller
    {
        private ShuliDB db = new ShuliDB();

        // GET: FanClub
        public ActionResult Index()
        {
            return View(db.FanClub.ToList());
        }

        // GET: FanClub/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FanClubModel fanClubModel = db.FanClub.Find(id);
            if (fanClubModel == null)
            {
                return HttpNotFound();
            }
            return View(fanClubModel);
        }

        // GET: FanClub/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FanClub/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Bday,gender,joinYear")] FanClubModel fanClubModel)
        {
            if (ModelState.IsValid)
            {
                db.FanClub.Add(fanClubModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fanClubModel);
        }

        // GET: FanClub/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FanClubModel fanClubModel = db.FanClub.Find(id);
            if (fanClubModel == null)
            {
                return HttpNotFound();
            }
            return View(fanClubModel);
        }

        // POST: FanClub/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Bday,gender,joinYear")] FanClubModel fanClubModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fanClubModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fanClubModel);
        }

        // GET: FanClub/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FanClubModel fanClubModel = db.FanClub.Find(id);
            if (fanClubModel == null)
            {
                return HttpNotFound();
            }
            return View(fanClubModel);
        }

        // POST: FanClub/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FanClubModel fanClubModel = db.FanClub.Find(id);
            db.FanClub.Remove(fanClubModel);
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
