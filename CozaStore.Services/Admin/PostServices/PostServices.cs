// <copyright file="PostServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.PostServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AutoMapper;
    using CozaStore.Data.EntityContext;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;
    using CozaStore.Model.ResponseModel;
    using CozaStore.Services.PostServices;
    using Microsoft.EntityFrameworkCore;

    public class PostServices : ServicesBase<PostEntities>, IPostServices
    {
        #region Contructor, Variable
        private readonly CozaStoreContext _context;
        private readonly IMapper _mapper;

        public PostServices(CozaStoreContext context, IMapper mapper)
            : base(context)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Add
        public void Add(PostModel postModel)
        {
            var post = _mapper.Map<PostModel, PostEntities>(postModel);
            _context.Add(post);
            _context.SaveChanges();
        }
        #endregion

        #region Update
        public void Update(PostModel postModel)
        {
            var post = _mapper.Map<PostModel, PostEntities>(postModel);
            _context.Update(post);
            _context.SaveChanges();
        }
        #endregion

        #region Delete
        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }
        #endregion

        #region GetPosts
        public async Task<List<ListPosts>> GetPosts()
        {
            var post = _context.Post.Select(post
               => new ListPosts
               {
                   Id = post.Id,
                   PostTitle = post.PostTitle,
                   TopicId = post.TopicId,
                   Image = post.Image,
                   Status = post.Status
               }).ToListAsync();
            return await post;
        }
        #endregion

        #region GetById
        public ListPosts GetById(int idPost)
        {
            var post = _context.Post.Select(
                p => new ListPosts
                {
                    Id = p.Id,
                    PostTitle = p.PostTitle,
                    TopicId = p.TopicId,
                    Image = p.Image,
                    Status = p.Status
                }).Where(p => p.Id == idPost).SingleOrDefault();
            return post;
        }
        #endregion

        #region GetPostsPaging
        public Task<PageList<ListPosts>> GetPostsPaging(PagingParameters pagingParameters)
        {
            var post = _context.Post.Select(
                p => new ListPosts
                {
                    Id = p.Id,
                    PostTitle = p.PostTitle,
                    TopicId = p.TopicId,
                    Image = p.Image,
                    Status = p.Status
                }).ToList();
            var result = PageList<ListPosts>.GetPageList(post, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }
        #endregion GetPostsPaging

        #region GetsPostsByTopic
        public Task<PageList<ListPosts>> GetsPostsByTopic(PagingParameters pagingParameters, int topicId)
        {
            var posts = from p in _context.Post
                       join t in _context.Topic on p.TopicId equals t.Id
                       where t.Id == topicId
                       select new ListPosts
                       {
                           Id = p.Id,
                           PostTitle = p.PostTitle,
                           TopicId = p.TopicId,
                           Image = p.Image,
                           Status = p.Status,
                           TopicName = t.TopicName
                       };
            var listPosts = posts.ToList();
            var result = PageList<ListPosts>.GetPageList(listPosts, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }
        #endregion

        #region GetLatestPosts
        public Task<PageList<ListPosts>> GetLatestPosts(PagingParameters pagingParameters)
        {
            var posts = from p in _context.Post
                        join t in _context.Topic on p.TopicId equals t.Id
                        where p.CreateDate.Day - DateTime.Now.Day < 7
                        select new ListPosts
                        {
                            Id = p.Id,
                            PostTitle = p.PostTitle,
                            TopicId = p.TopicId,
                            Image = p.Image,
                            Status = p.Status,
                            TopicName = t.TopicName
                        };
            var listPosts = posts.ToList();
            var result = PageList<ListPosts>.GetPageList(listPosts, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }
        #endregion

        #region SearchPosts
        public Task<PageList<ListPosts>> SearchPosts(string keyWordSearch, PagingParameters pagingParameters)
        {
            var posts = from p in _context.Post
                        join t in _context.Topic on p.TopicId equals t.Id
                        where p.PostTitle.ToLower().Contains(keyWordSearch.ToLower())
                        select new ListPosts
                        {
                            Id = p.Id,
                            PostTitle = p.PostTitle,
                            TopicId = p.TopicId,
                            Image = p.Image,
                            Status = p.Status,
                            TopicName = t.TopicName
                        };
            var posts2 = posts.ToList();
            var result = PageList<ListPosts>.GetPageList(posts2, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }
        #endregion

        public List<PostModel> GetByAlias(string alias)
        {
            throw new NotImplementedException();
        }
    }
}
