using System.Linq;
using System.Web.Mvc;
using Suanha3.Models;

namespace Suanha3.Controllers
{
    public class ServiceController : Controller
    {
        private SuaNhaDbContext db = new SuaNhaDbContext();

        // GET: Service
        public ActionResult Index()
        {
            var services = db.Services.OrderByDescending(s => s.CreatedDate).ToList();
            return View(services);
        }

        // GET: Service/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Service/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Service service)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(service);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Thêm dịch vụ thành công!";
                return RedirectToAction("Index");
            }
            return View(service);
        }

        // GET: Service/Edit/5
        public ActionResult Edit(int id)
        {
            var service = db.Services.Find(id);
            if (service == null)
                return HttpNotFound();
            return View(service);
        }

        // POST: Service/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Service service)
        {
            if (ModelState.IsValid)
            {
                db.Entry(service).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                TempData["SuccessMessage"] = "Cập nhật dịch vụ thành công!";
                return RedirectToAction("Index");
            }
            return View(service);
        }

        // GET: Service/Delete/5
        public ActionResult Delete(int id)
        {
            var service = db.Services.Find(id);
            if (service == null)
                return HttpNotFound();
            return View(service);
        }

        // POST: Service/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var service = db.Services.Find(id);
            if (service != null)
            {
                db.Services.Remove(service);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Đã xóa dịch vụ!";
            }
            return RedirectToAction("Index");
        }
    }
}
