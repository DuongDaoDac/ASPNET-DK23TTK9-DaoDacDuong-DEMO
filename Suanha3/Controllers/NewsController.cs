using Suanha3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suanha3.Controllers
{
    public class NewsController : Controller
    {
        private const string V = "23/04/2025";
        private static List<News> newsList = new List<News>
        {
            new News { Id = 1, Title = "Tuyển thợ sửa nhà lương cao", Category = "Tuyển dụng", Content = "Công ty cần tuyển 5 thợ sửa nhà tại TP.HCM.", CreatedDate="24/04/2025" },
            new News { Id = 2, Title = "Xu hướng sơn nhà đẹp 2025", Category = "Trang trí", Content = "Những màu sơn hot nhất 2025.", CreatedDate=V }
        };

        public ActionResult Index()
        {
            return View(newsList);
        }

        public ActionResult Details(int id)
        {
            var news = newsList.Find(n => n.Id == id);
            if (news == null)
                return HttpNotFound();
            return View(news);
        }

    }
}