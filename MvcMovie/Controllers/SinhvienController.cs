using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class SinhvienControler : Controller
    {
        public IActionResult dulieu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult dulieu(Sinhvien sv)
        {
            string strOutput  = "xin chao" + sv.Hoten + "-" + sv.Diachi + "-" + sv.Tuoi + "-" + sv.Sodienthoai;
            ViewBag.dulieu = strOutput ;
            return View();
        }

    }
}