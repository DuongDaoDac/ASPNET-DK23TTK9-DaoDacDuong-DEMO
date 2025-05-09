using Suanha3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Suanha3.Controllers
{
    public class AdminContactController : Controller
    {
        private SuanhaDbContext db = new SuanhaDbContext();

        /// <summary>
        /// Hiển thị danh sách liên hệ từ khách hàng
        /// </summary>
        /// <returns>View danh sách liên hệ</returns>
        public ActionResult Index()
        {
            var contacts = db.Contacts.OrderByDescending(c => c.SubmittedDate).ToList();
            return View(contacts);
        }

        /// <summary>
        /// Xóa liên hệ theo ID
        /// </summary>
        /// <param name="id">Mã liên hệ</param>
        /// <returns>Chuyển về trang danh sách liên hệ</returns>
        public ActionResult Delete(int id)
        {
            var contact = db.Contacts.Find(id);
            if (contact == null)
            {
                // Nếu không tìm thấy thì trả về trang 404 hoặc thông báo
                return HttpNotFound("Liên hệ không tồn tại hoặc đã bị xóa.");
            }

            db.Contacts.Remove(contact);
            db.SaveChanges();

            // Trả về thông báo xóa thành công qua TempData
            TempData["SuccessMessage"] = "Đã xóa thành công thông tin liên hệ của khách hàng.";

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
