using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Sitecore.FakeDb;
using Suanha3.Models;




namespace SuaNha.Controllers
{
    // [Authorize] // Thêm attribute này để yêu cầu đăng nhập cho trang admin
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditInterface()
        {
            ViewBag.WebsiteTitle = "Sửa nhà 347"; // Lấy từ cấu hình hoặc database
            ViewBag.BannerUrl = "/Content/images/banner1.jpg"; // Lấy từ cấu hình hoặc database
            return View();
        }

        [HttpPost]
        public ActionResult SaveInterfaceChanges()
        {
            // Xử lý lưu các thay đổi giao diện
            return RedirectToAction("Index");
        }

        public ActionResult ManageContacts()
        {
            // Truy vấn và hiển thị danh sách liên hệ từ database
            return View();
        }
        [HttpPost]
        public ActionResult SavePrices()
        {
            // Xử lý lưu các thay đổi đơn giá
            return RedirectToAction("EditPrices");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveInterfaceChanges(string Title, string BannerUrl)
        {
            // Lưu các thay đổi giao diện vào cấu hình hoặc database
            // Ví dụ:
            // ConfigurationManager.AppSettings["WebsiteTitle"] = Title;
            // SaveBannerUrlToDatabase(BannerUrl);

            TempData["SuccessMessage"] = "Giao diện đã được lưu thành công!";
            return RedirectToAction("EditInterface");
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditPricing()
        {
            return View();
        }
        public ActionResult EditPrices()
        {
            // Truy vấn và hiển thị form chỉnh sửa đơn giá
            return View();
        }
    }
}