using BossiIt.BlogServer.Domain.Models;
using MongoDB.Driver;

namespace BossiIt.BlogServer.Domain.Repositories.Implementation
{
    public class BlogPostRepository : IBlogPostRepository

    {
        private readonly IMongoCollection<BlogPost> _collection;

        public BlogPostRepository(IMongoClient client)
        {
            var database = client.GetDatabase("BlogDb");
            _collection = database.GetCollection<BlogPost>("BlogPosts");
        }

        public async Task CreateAsync(BlogPost blogPost)
        {
            blogPost.Id = Guid.NewGuid().ToString();
            await _collection.InsertOneAsync(blogPost);
        }

        public async Task<BlogPost?> GetAsync(string id)
        {
            return await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(string id, BlogPost updatedBlogPost)
        {
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedBlogPost);
        }

        public async Task RemoveAsync(string id)
        {
            await _collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
