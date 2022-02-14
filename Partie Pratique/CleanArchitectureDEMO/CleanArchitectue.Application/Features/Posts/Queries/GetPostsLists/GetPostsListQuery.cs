using CleanArchitectue.Application.Features.Posts.Queries.GetPostLists;
using MediatR;

using System.Collections.Generic;


namespace CleanArchitectue.Application.Features.Posts.Queries.GetPostsLists
{
    public class GetPostsListQuery : IRequest<List<GetPostsListViewModel>>
    {

    }
}
