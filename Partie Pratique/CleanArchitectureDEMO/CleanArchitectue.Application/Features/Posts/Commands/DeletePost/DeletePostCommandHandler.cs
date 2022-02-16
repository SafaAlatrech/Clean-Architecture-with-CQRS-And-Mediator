using CleanArchitectue.Application.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectue.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
    {
        private readonly IPostRepository _postRepository;
        public DeletePostCommandHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetByIdAsync(request.PostId);

            await _postRepository.DeleteAsync(post);

            return Unit.Value;
        }

    }

}
