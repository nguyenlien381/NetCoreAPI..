using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Employee El)
    {
        string strOutput = "xin chao " + El.Manhanvien + " - " + El.Tennhanvien + " - " + El.Tuoi + "-" + El.Luong ;
            ViewBag.infoEmployee = strOutput;
            return View();
    }
}
}
