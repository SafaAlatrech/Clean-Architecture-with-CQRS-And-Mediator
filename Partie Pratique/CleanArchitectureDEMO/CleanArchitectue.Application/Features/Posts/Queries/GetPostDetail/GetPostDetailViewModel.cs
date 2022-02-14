using CleanArchitectue.Application.Features.Posts.Queries.GetPostLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectue.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public CategoryDto Category { get; set; }
    }
}
