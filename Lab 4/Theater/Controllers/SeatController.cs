using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Theater.DAL;
using Theater.Models;

namespace Theater.Controllers
{
    public class SeatController : Controller
    {
		private readonly GenericRepository<Seat> repo;

		public SeatController()
		{
			repo = new GenericRepository<Seat>(new TheaterContext());
		}

		// GET: Seat
		public ActionResult Index()
        {
			return View(repo.GetAll());
		}

        // GET: Seat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seat seat = repo.GetById(id);
			if (seat == null)
            {
                return HttpNotFound();
            }
            return View(seat);
        }

        // GET: Seat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seat/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SeatId,Number,Row")] Seat seat)
        {
            if (ModelState.IsValid)
            {
				repo.Insert(seat);
				repo.Save();
				return RedirectToAction("Index");
            }

            return View(seat);
        }

        // GET: Seat/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seat seat = repo.GetById(id);
			if (seat == null)
            {
                return HttpNotFound();
            }
            return View(seat);
        }

        // POST: Seat/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SeatId,Number,Row")] Seat seat)
        {
            if (ModelState.IsValid)
            {
				repo.Update(seat);
				repo.Save();
				return RedirectToAction("Index");
            }
            return View(seat);
        }

        // GET: Seat/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seat seat = repo.GetById(id);
            if (seat == null)
            {
                return HttpNotFound();
            }
            return View(seat);
        }

        // POST: Seat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			repo.Delete(id);
			repo.Save();
			return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
				repo.Dispose();
			}
            base.Dispose(disposing);
        }
    }
}
