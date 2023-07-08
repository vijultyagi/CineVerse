using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CineVerseWeb.Data;
using CineVerseWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CineVerseWeb.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Movie> moviesList = _db.Movies;
            return View(moviesList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Movie movie)
        {
            // Custom Validation (uncomment validation summary to display this error)
            if (int.Parse(movie.ReleaseYear) > DateTime.Now.Year)
            {
                ModelState.AddModelError(string.Empty, "Release year must not be after current year");
            }

            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();

                TempData["success"] = "Movie created successfully!";

                return RedirectToAction("Index");
            }

            return View();
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Find uses the primary key to get the data
            // If we want to find using any other column, we can use 'FirstorDefault' or 'SingleorDefault'
            var movie = _db.Movies.Find(id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        //POST
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Movie movie)
        {
            // Custom Validation (Not Working | TO-DO)
            if (int.Parse(movie.ReleaseYear) > DateTime.Now.Year)
            {
                ModelState.AddModelError(string.Empty, "Release year must not be after current year");
            }

            if (ModelState.IsValid)
            {
                _db.Movies.Update(movie);
                _db.SaveChanges();

                TempData["success"] = "Movie edited successfully!";

                return RedirectToAction("Index");
            }

            return View(movie);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var movie = _db.Movies.Find(id);

            if (movie == null)
            {
                return NotFound();
            }
            _db.Remove(movie);
            _db.SaveChanges();

            TempData["success"] = "Movie deleted successfully!";

            return RedirectToAction("Index");
        }
    }
}

