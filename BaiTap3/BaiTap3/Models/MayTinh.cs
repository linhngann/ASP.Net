using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap3.Models
{
    public class MayTinh
    {
        public string MaMay {  get; set; }
        public string TenMay {  get; set; }
        public double GiaBan {  get; set; }
        public DateTime NgaySanXuat {  get; set; }
        public string HangSanXuat {  get; set; }

        public List<MayTinh> khoitao()
        {
            List<MayTinh> ds = new List<MayTinh>();
            ds.Add(new MayTinh
            {
                MaMay = "001",
                TenMay = "HP fff",
                GiaBan = 120000,
                NgaySanXuat = new DateTime(2012, 3, 15),
                HangSanXuat = "Lenovo",
            });
            ds.Add(new MayTinh
            {
                MaMay = "002",
                TenMay = "HP ccc",
                GiaBan = 340000,
                NgaySanXuat = new DateTime(2012, 3, 15),
                HangSanXuat = "Lenovo",
            });
            ds.Add(new MayTinh
            {
                MaMay = "003",
                TenMay = "asus",
                GiaBan = 120000,
                NgaySanXuat = new DateTime(2012, 3, 15),
                HangSanXuat = "Asus",
            });
            ds.Add(new MayTinh
            {
                MaMay = "004",
                TenMay = "HP fff",
                GiaBan = 170000,
                NgaySanXuat = new DateTime(2012, 3, 15),
                HangSanXuat = "Lenovo",
            });
            ds.Add(new MayTinh
            {
                MaMay = "005",
                TenMay = "HP fff",
                GiaBan = 670000,
                NgaySanXuat = new DateTime(2012, 3, 15),
                HangSanXuat = "Lenovo",
            });
            return ds;

        }
    }
}