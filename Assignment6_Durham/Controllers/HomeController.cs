using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment6_Durham.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment6_Durham.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieFormContext _context;
        
        public HomeController(ILogger<HomeController> logger, MovieFormContext context)
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
        
        [HttpGet]
        public IActionResult NewMovieForm()
        {
           ViewBag.Categories =  _context.Categories.ToList();

           return View("NewMovieForm", new SubmissionForm());
        }
        [HttpPost]
        public IActionResult NewMovieForm(SubmissionForm response)
        {
            if (ModelState.IsValid)
            {
                // Use _context directly to add the response
                _context.Movies.Add(response);
                _context.SaveChanges();
                return View("Confirmation");
            }
            else //invalid data
            {
                ViewBag.Categories =  _context.Categories.ToList();

                return View(response);
            }
        }

        public IActionResult MovieList()
        {
            // Query the database for all PG-13 movies
            var forms = _context.Movies.ToList();

            return View(forms);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
                
            ViewBag.Categories =  _context.Categories.ToList();
            
            return View("NewMovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(SubmissionForm updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);
            
            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(SubmissionForm updatedInfo)
        {
            _context.Movies.Remove(updatedInfo);
            _context.SaveChanges();
            
            return RedirectToAction("MovieList");
        }
    }
}