using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Theater.DAL;
using Theater.Models;

namespace Theater.Controllers
{
    public class EmployeeController : Controller
    {
		private readonly GenericRepository<Employee> repo;
		private readonly GenericRepository<EmployeeDetails> DetailsRepo;

		public EmployeeController()
		{
			repo = new GenericRepository<Employee>(new TheaterContext());
			DetailsRepo = new GenericRepository<EmployeeDetails>(new TheaterContext());
		}

		// GET: Employee
		public ActionResult Index()
        {
            return View(repo.GetAll().Include(e => e.EmployeeDetails).ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = repo.GetById(id);
			if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,FirstName,LastName,EmployeeDetails")] Employee employee, [Bind(Include = "EmployeeDetailsId,Address,PhoneNumber,Birthday")] EmployeeDetails employeeDetails)
        {
            if (ModelState.IsValid)
            {
				employee.EmployeeDetails = employeeDetails;
				repo.Insert(employee);
				DetailsRepo.Insert(employeeDetails);
				repo.Save();
                DetailsRepo.Save();
				return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = repo.GetById(id);
			if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,FirstName,LastName,EmployeeDetails")] Employee employee, [Bind(Include = "EmployeeDetailsId,Address,PhoneNumber,Birthday")] EmployeeDetails employeeDetails)
        {
            if (ModelState.IsValid)
            {
				employeeDetails.EmployeeDetailsId = employee.EmployeeId;
				employee.EmployeeDetails = employeeDetails;
				repo.Update(employee);
                DetailsRepo.Update(employeeDetails);
				repo.Save();
                DetailsRepo.Save();
				return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = repo.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employee/Delete/5
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
