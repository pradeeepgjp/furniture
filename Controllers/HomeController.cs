using furniture.Data;
using furniture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace furniture.Controllers
{
    public class HomeController : Controller
    {
        private readonly PradeepDbContext _Db;

        public HomeController(PradeepDbContext Db)
        {
            _Db = Db;
        }


        public IActionResult Index()
        {

            return View();
        }
        public IActionResult About()
        {

            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }
        public IActionResult Furniture()
        {

            return View();
        }
        public IActionResult Login(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Pradeep? a = _Db.PradeepList.Find(id);
            if (a == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(Pradeep v)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Pradeep x)
        {
            if (ModelState.IsValid)
            {
                _Db.PradeepList.Add(x);
                _Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Shop()
        {

            return View();
        }
    }
}


    