using AutoMapper;
using CleanArchitectue.Application.Features.Posts.Commands.CreatePost;
using CleanArchitectue.Application.Features.Posts.Commands.DeletePost;
using CleanArchitectue.Application.Features.Posts.Commands.UpdatePost;
using CleanArchitectue.Application.Features.Posts.Queries.GetPostDetail;
using CleanArchitectue.Application.Features.Posts.Queries.GetPostLists;
using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectue.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, GetPostsListViewModel>().ReverseMap();
            CreateMap<Post, GetPostDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();
        }
    }

}