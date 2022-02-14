using CleanArchitectue.Application.Contracts;
using CleanArchitectue.Application.Features.Posts.Queries.GetPostLists;
using MediatR;
using AutoMapper;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectue.Application.Features.Posts.Queries.GetPostsLists
{
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<GetPostsListViewModel>>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;


        public GetPostsListQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
 
        public async Task<List<GetPostsListViewModel>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _postRepository.GetAllPostsAsync(true);
            return _mapper.Map<List<GetPostsListViewModel>>(allPosts);
        }
    }
}
