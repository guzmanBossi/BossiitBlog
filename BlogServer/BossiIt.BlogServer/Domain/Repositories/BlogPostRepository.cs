using BossiIt.BlogServer.Domain.Models;
using MongoDB.Driver;

namespace BossiIt.BlogServer.Domain.Repositories
{
    public class BlogPostRepository
    {
        private readonly IMongoCollection<BlogPost> _collection;

        public BlogPostRepository(IMongoClient client)
        {
            var database = client.GetDatabase("BlogDb");
            _collection = database.GetCollection<BlogPost>("BlogPosts");
        }
    }
}
