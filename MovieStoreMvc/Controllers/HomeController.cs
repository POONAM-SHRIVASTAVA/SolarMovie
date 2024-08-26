using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Repositories.Abstract;
using MovieStoreMvc.Repositories.Implementation;

namespace MovieStoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IReviewService _reviewService; // Add this line

        // Modify the constructor to include IReviewService
        public HomeController(IMovieService movieService, IReviewService reviewService)
        {
            _movieService = movieService;
            _reviewService = reviewService; // Assign it here
        }
        public IActionResult Index(string term="", int currentPage = 1)
        {
            var movies = _movieService.List(term,true,currentPage);
            return View(movies);
        }
        public IActionResult MovieDetail(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            var reviews = _reviewService.GetReviewsByMovie(movieId);
            ViewBag.Reviews = reviews;
            return View(movie);
        }


        public IActionResult About()
        {
            return View();
        }


    }
}
