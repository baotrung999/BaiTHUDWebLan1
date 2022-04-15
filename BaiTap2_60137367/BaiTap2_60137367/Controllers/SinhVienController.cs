using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2_60137367.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection field)
        {
            ViewBag.Id = field["MaSV"];
            ViewBag.Name = field["HoTen"];
            ViewBag.Marks = field["Diem"];


            return View(ViewBag);
        }
    }
}