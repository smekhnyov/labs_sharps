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
    public class SessionController : Controller
    {
        private readonly GenericRepository<Session> repo;
		private readonly GenericRepository<Event> eventRepo;
		private readonly GenericRepository<Hall> hallRepo;

		public SessionController()
        {
            repo = new GenericRepository<Session>(new TheaterContext());
			eventRepo = new GenericRepository<Event>(new TheaterContext());
			hallRepo = new GenericRepository<Hall>(new TheaterContext());
		}

        // GET: Session
        public ActionResult Index()
        {
            var sessions = repo.GetAll().Include(s => s.Event).Include(s => s.Hall).ToList();
			return View(sessions);
		}

        // GET: Session/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Session session = repo.GetById(id);
            if (session == null)
            {
                return HttpNotFound();
            }
            return View(session);
        }

        // GET: Session/Create
        public ActionResult Create()
        {
            ViewBag.EventId = new SelectList(eventRepo.GetAll(), "EventId", "Name");
            ViewBag.HallId = new SelectList(hallRepo.GetAll(), "HallId", "HallId");
            return View();
        }

        // POST: Session/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SessionId,Start,End,EventId,HallId")] Session session)
        {
            if (ModelState.IsValid)
            {
                repo.Insert(session);
                repo.Save();
                return RedirectToAction("Index");
            }

            ViewBag.EventId = new SelectList(eventRepo.GetAll(), "EventId", "Name", session.EventId);
            ViewBag.HallId = new SelectList(hallRepo.GetAll(), "HallId", "HallId", session.HallId);
            return View(session);
        }

        // GET: Session/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Session session = repo.GetById(id);
            if (session == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventId = new SelectList(eventRepo.GetAll(), "EventId", "Name", session.EventId);
            ViewBag.HallId = new SelectList(hallRepo.GetAll(), "HallId", "HallId", session.HallId);
            return View(session);
        }

        // POST: Session/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SessionId,Start,End,EventId,HallId")] Session session)
        {
            if (ModelState.IsValid)
            {
                repo.Update(session);
				repo.Save();
				return RedirectToAction("Index");
			}
            ViewBag.EventId = new SelectList(eventRepo.GetAll(), "EventId", "Name", session.EventId);
            ViewBag.HallId = new SelectList(hallRepo.GetAll(), "HallId", "HallId", session.HallId);
            return View(session);
        }

        // GET: Session/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Session session = repo.GetById(id);
            if (session == null)
            {
                return HttpNotFound();
            }
            return View(session);
        }

        // POST: Session/Delete/5
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
