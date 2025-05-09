using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suanha3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Trang chủ
        public ActionResult Index()
        {
            return View();
        }

        // GET: Giới thiệu
        public ActionResult About()
        {
            return View();
        }

        // GET: Tin tức
        public ActionResult News()
        {
            return View();
        }

        // GET: Liên hệ
        public ActionResult Contact()
        {
            return View();
        }

        // GET: Đơn giá
        public ActionResult Pricing()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
    }
}