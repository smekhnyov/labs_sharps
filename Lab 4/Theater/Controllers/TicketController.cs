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
using static System.Collections.Specialized.BitVector32;

namespace Theater.Controllers
{
    public class TicketController : Controller
    {
        private readonly GenericRepository<Ticket> repo;
		private readonly GenericRepository<Seat> seatRepo;
		private readonly GenericRepository<Session> sessionRepo;

		public TicketController()
		{
			repo = new GenericRepository<Ticket>(new TheaterContext());
			seatRepo = new GenericRepository<Seat>(new TheaterContext());
			sessionRepo = new GenericRepository<Session>(new TheaterContext());
		}

		// GET: Ticket
		public ActionResult Index()
        {
            var tickets = repo.GetAll().Include(t => t.Seat).Include(t => t.Session).ToList();
            return View(tickets);
        }

        // GET: Ticket/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = repo.GetById(id);
			if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // GET: Ticket/Create
        public ActionResult Create()
        {
            ViewBag.SeatId = new SelectList(seatRepo.GetAll(), "SeatId", "SeatId");
            ViewBag.SessionId = new SelectList(sessionRepo.GetAll(), "SessionId", "SessionId");
            return View();
        }

        // POST: Ticket/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TicketId,SessionId,Cost,SeatId")] Ticket ticket)
		{
            if (ModelState.IsValid)
            {
				repo.Insert(ticket);
				repo.Save();
				return RedirectToAction("Index");
            }

            ViewBag.SeatId = new SelectList(seatRepo.GetAll(), "SeatId", "SeatId", ticket.SeatId);
            ViewBag.SessionId = new SelectList(sessionRepo.GetAll(), "SessionId", "SessionId", ticket.SessionId);
            return View(ticket);
        }

        // GET: Ticket/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = repo.GetById(id);
			if (ticket == null)
            {
                return HttpNotFound();
            }
            ViewBag.SeatId = new SelectList(seatRepo.GetAll(), "SeatId", "SeatId", ticket.SeatId);
            ViewBag.SessionId = new SelectList(sessionRepo.GetAll(), "SessionId", "SessionId", ticket.SessionId);
            return View(ticket);
        }

        // POST: Ticket/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TicketId,SessionId,Cost,SeatId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
				repo.Update(ticket);
				repo.Save();
				return RedirectToAction("Index");
            }
			ViewBag.SeatId = new SelectList(seatRepo.GetAll(), "SeatId", "SeatId", ticket.SeatId);
			ViewBag.SessionId = new SelectList(sessionRepo.GetAll(), "SessionId", "SessionId", ticket.SessionId);
			return View(ticket);
        }

        // GET: Ticket/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = repo.GetById(id);
			if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // POST: Ticket/Delete/5
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
