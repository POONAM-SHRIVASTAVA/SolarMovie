using MovieStoreMvc.Models.Domain;

namespace MovieStoreMvc.Repositories.Abstract
{
    public interface IReviewService
    {
        IEnumerable<Review> GetReviewsByMovie(int movieId);
        bool AddReview(Review review);
    }
}

