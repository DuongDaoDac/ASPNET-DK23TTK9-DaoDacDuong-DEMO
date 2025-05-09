using Suanha3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suanha3.Controllers
{
    public class ContactController : Controller
    {
        private SuaNhaDbContext db = new SuaNhaDbContext();

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.CreatedDate = DateTime.Now;
                db.Contacts.Add(contact);
                db.SaveChanges();
                ViewBag.Message = "Cảm ơn bạn đã liên hệ với chúng tôi!";
                ModelState.Clear(); // Clear form sau khi submit thành công
                return View();
            }
            return View(contact);
        }
        public ActionResult Details(int id)
        {
            var contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        public ActionResult Create()
        {
            return View();
        }


    }
}