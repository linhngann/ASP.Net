using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap3.Models;

namespace BaiTap3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MayTinh mt = new MayTinh();
            List<MayTinh> ds = mt.khoitao();
            return View(ds);
        }
        public ActionResult DanhSach2()
        {
            MayTinh mt = new MayTinh();
            List<MayTinh> ds = mt.khoitao().OrderBy(m=>m.GiaBan).Take(2).ToList();
            return View(ds);
        }
        public ActionResult SapXep()
        {
            MayTinh mt = new MayTinh();
            List<MayTinh> ds = mt.khoitao().OrderBy(m => m.GiaBan).ToList();
            return View(ds);
        }
        public ActionResult Ten()
        {
            MayTinh mt = new MayTinh();
            List<MayTinh> ds = mt.khoitao().Where(m=>m.TenMay=="asus").ToList();
            return View(ds);
        }
    }
}