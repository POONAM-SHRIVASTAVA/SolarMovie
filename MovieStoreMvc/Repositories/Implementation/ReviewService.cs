using Microsoft.EntityFrameworkCore;
using MovieStoreMvc.Models.Domain;
using MovieStoreMvc.Repositories.Abstract;

namespace MovieStoreMvc.Repositories.Implementation
{
    public class ReviewService : IReviewService
    {
        private readonly DatabaseContext _context;

        public ReviewService(DatabaseContext context)
        {
            _context = context;
        }
      


        public bool AddReview(Review review)
        {
            _context.Reviews.Add(review);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Review> GetReviewsByMovie(int movieId)
        {
            return _context.Reviews.Where(r => r.MovieId == movieId).ToList();
        }
    }
}
