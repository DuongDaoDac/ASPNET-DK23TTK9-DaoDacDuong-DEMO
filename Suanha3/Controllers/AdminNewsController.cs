using System.Linq;
using System.Web.Mvc;
using Suanha3.Models;
using System.Globalization;
using System;

namespace Suanha3.Controllers
{
    public class AdminNewsController : Controller
    {
        private SuaNhaDbContext db = new SuaNhaDbContext();

        // Danh sách tin tức
        public ActionResult Index()
        {
            var newsList = db.News.OrderByDescending(n => n.CreatedDate).ToList();
            return View(newsList);
        }

        // GET: Thêm mới
        public ActionResult Create()
        {
            return View();
        }

        // POST: Thêm mới
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(News news)
        {
            if (ModelState.IsValid)
            {
                news.CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                db.News.Add(news);
                db.SaveChanges();

                TempData["SuccessMessage"] = "Đã thêm bài viết mới thành công!";
                return RedirectToAction("Index");
            }
            return View(news);
        }

        // GET: Sửa bài viết
        public ActionResult Edit(int id)
        {
            var news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound("Bài viết không tồn tại.");
            }
            return View(news);
        }

        // POST: Sửa bài viết
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(News news)
        {
            if (ModelState.IsValid)
            {
                var existing = db.News.Find(news.Id);
                if (existing == null)
                {
                    return HttpNotFound("Không tìm thấy bài viết để cập nhật.");
                }

                existing.Title = news.Title;
                existing.Description = news.Description;
                existing.ImageUrl = news.ImageUrl;
                existing.Content = news.Content;

                db.SaveChanges();

                TempData["SuccessMessage"] = "Cập nhật bài viết thành công!";
                return RedirectToAction("Index");
            }
            return View(news);
        }

        // Xóa bài viết
        public ActionResult Delete(int id)
        {
            var news = db.News.Find(id);
            if (news == null)
            {
                return HttpNotFound("Bài viết không tồn tại.");
            }

            db.News.Remove(news);
            db.SaveChanges();

            TempData["SuccessMessage"] = "Đã xóa bài viết thành công!";
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
        public ActionResult Contact()
        {
            Contact contact = new Contact();
            return View(contact);
        }

    }
}
