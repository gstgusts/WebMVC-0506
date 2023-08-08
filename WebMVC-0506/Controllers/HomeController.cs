using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using WebMVC_0506.Data;
using WebMVC_0506.Data.Models;
using WebMVC_0506.Models;

namespace WebMVC_0506.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly SchoolContext _schoolContext;

        public HomeController(ILogger<HomeController> logger, SchoolContext context)
        {
            _logger = logger;
            _schoolContext = context;
        }

        public IActionResult Index()
        {

            var model = new IndexPageModel();
            model.Name = "Gusts";

            using (var db = _schoolContext)
            {
               model.Names = db.Courses.Where(c => c.Title.StartsWith("C")).Select(c => c.Title).ToList();
               //var result = db.Database.SqlQuery<Course>($"select C.* from [Course] AS C").ToList();
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}