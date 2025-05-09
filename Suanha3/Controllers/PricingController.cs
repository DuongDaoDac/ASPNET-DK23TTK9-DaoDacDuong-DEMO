
using Suanha3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuaNha.Controllers
{
    public class PricingController : Controller
    {
        private static List<Pricing> pricings = new List<Pricing>
        {
            new Pricing { Id = 1, ServiceName = "Sửa nhà trọn gói", UnitPrice = 50000000 },
            new Pricing { Id = 2, ServiceName = "Sơn nhà", UnitPrice = 15000000 }
        };

        public ActionResult Index()
        {
            return View(pricings);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pricing pricing)
        {
            if (ModelState.IsValid)
            {
                pricing.Id = pricings.Count + 1;
                pricings.Add(pricing);
                return RedirectToAction("Index");
            }
            return View(pricing);
        }

        public ActionResult Edit(int? id)
        {
            var pricing = pricings.Find(p => p.Id == id);
            if (pricing == null)
                return HttpNotFound();
            return View(pricing);
        }

        [HttpPost]
        public ActionResult Edit(Pricing pricing)
        {
            if (ModelState.IsValid)
            {
                var existing = pricings.Find(p => p.Id == pricing.Id);
                if (existing != null)
                {
                    existing.ServiceName = pricing.ServiceName;
                    existing.UnitPrice = pricing.UnitPrice;
                }
                return RedirectToAction("Index");
            }
            return View(pricing);
        }

        public ActionResult Delete(int? id)
        {
            var pricing = pricings.Find(p => p.Id == id);
            if (pricing == null)
                return HttpNotFound();
            return View(pricing);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            var pricing = pricings.Find(p => p.Id == id);
            if (pricing != null)
                pricings.Remove(pricing);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var pricing = pricings.Find(p => p.Id == id);
            if (pricing == null)
                return HttpNotFound();
            return View(pricing);
        }
    }
}