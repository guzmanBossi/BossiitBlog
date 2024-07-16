using BossiIt.BlogServer.Domain.Models;

namespace BossiIt.BlogServer.Domain.Repositories
{
    interface IBlogPostRepository
    {
        Task CreateAsync(BlogPost blogPost);
        Task<BlogPost?> GetAsync(string id);
        Task RemoveAsync(string id);
    }
}
