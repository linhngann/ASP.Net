using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2.Controllers
{
    public class HomeController : Controller
    {
        // chuyển hướng qua action khác, cùng controller
        // return RedirectToAction("tên action")
        // chuyển hướng qua action khác, khác controller
        // return RedirectToAction("tên action", "tên controller")
        // chuyển hướng qua route khác
        // return RedirectToRoute("Tên route")
        // chuyển hướng qua url
        // return Redirect("tên url")
        public ActionResult TrangChu()
        {
            /*return RedirectToAction("Index", "TinTuc");*/
            return View();
            /* return RedirectToRoute("TinTuc");*/
            /*return Redirect("https://www.google.com/");*/
        }
        public ActionResult ThongTin()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }

    }
}