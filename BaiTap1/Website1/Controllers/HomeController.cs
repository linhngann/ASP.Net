using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website1.Controllers
{
    public class HomeController : Controller
    {
        // 1 Controller có nhiều action
        // mỗi 1 action chỉ có 1 view
        // empty: web rỗng, chưa chạy được
        // mvc: web có sẵn, chạy được
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HienThiTen()
        {
            return View();
        }
    }
}