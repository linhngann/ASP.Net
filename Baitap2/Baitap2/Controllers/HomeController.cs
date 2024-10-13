using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baitap2.Helper;
namespace Baitap2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Cách truyền dữ liệu từ Controller sang View
            //Cách 1: Truyền bằng ViewBag
            int a = 10;
            ViewBag.sum = new MathHelper().tinhTong(3, 5);
            //Cách 2: Truyền qua tham số của hàm View
            var sv1 = new SinhVien();
            sv1.ID = "001";
            sv1.Name = "Linh Ngân";
            sv1.Description = "Xinh";

            var sv2 = new SinhVien();
            sv1.ID = "002";
            sv1.Name = "Minh Nghĩa";
            sv1.Description = "xấu";

            List<SinhVien> sdList = new List<SinhVien>();

            sdList.Add(sv1);
            sdList.Add(sv2);
            return View(sdList);

        }
        
    }
}