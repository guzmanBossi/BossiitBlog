namespace BossiIt.BlogServer.Domain.Models
{
    public class BlogPost : Entity
    {
        public required string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
