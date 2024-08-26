namespace MovieStoreMvc.Models.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        
        public string Comment { get; set; }
        public int Rating { get; set; } // Rating from 1 to 5
        public DateTime CreatedAt { get; set; }

        public virtual Movie Movie { get; set; }

   
    }
}

