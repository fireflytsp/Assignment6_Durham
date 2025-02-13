using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment6_Durham.Models;

namespace Assignment6_Durham.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MusicFormContext _context;
        
        public HomeController(ILogger<HomeController> logger, MusicFormContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        public IActionResult NewMovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMovieForm(SubmissionForm response)
        {
            // Use _context directly to add the response
            _context.Add(response);
            _context.SaveChanges();
            return View("Confirmation");
        }
    }
}