using Microsoft.AspNetCore.Mvc;

namespace MovieRate
{
    public class MovieController : Controller
    {
        MovieContext db;
        public MovieController(MovieContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> movies = await Task.Run(() => db.Movies);
            ViewBag.Movies = movies;
            return View();
        }
    }
}
