using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Models.Domain;
using MovieStoreMvc.Repositories.Abstract;

namespace MovieStoreMvc.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;
        private readonly IMovieService _movieService;

        public ReviewController(IReviewService reviewService, IMovieService movieService)
        {
            _reviewService = reviewService;
            _movieService = movieService;
        }

        [HttpPost]
        public IActionResult Add(int movieId, string comment, int rating)
        {
            var review = new Review
            {
                MovieId = movieId,
                Comment = comment,
                Rating = rating,
                CreatedAt = DateTime.Now
            };

            var result = _reviewService.AddReview(review);

            if (result)
            {
                TempData["msg"] = "Review added successfully";
            }
            else
            {
                TempData["msg"] = "Error adding review";
            }

            return RedirectToAction("MovieDetail", "Home", new { movieId });
        }

        public IActionResult List(int movieId)
        {
            var reviews = _reviewService.GetReviewsByMovie(movieId);
            return View(reviews);
        }
    }
}
