
using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CleanArchitectue.Application.Contracts
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostsAsync(bool includeCategory);
        Task<Post> GetPostByIdAsync(Guid id, bool includeCategory);
    }
}
