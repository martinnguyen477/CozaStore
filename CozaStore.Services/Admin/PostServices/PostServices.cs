// <copyright file="PostServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.PostServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AutoMapper;
    using CozaStore.Data.EntityContext;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Model;
    using CozaStore.Services.PostServices;

    public class PostServices : IPostServices
    {
        private readonly CozaStoreContext _context;
        private readonly IMapper _mapper;

        public PostServices(CozaStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(PostModel postModel)
        {
            var post = _mapper.Map<PostModel, PostEntities>(postModel);
            _context.Add(post);
            _context.SaveChanges();
        }

        public void Update(PostModel postModel)
        {
            var post = _mapper.Map<PostModel, PostEntities>(postModel);
            _context.Update(post);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(id);
        }

        public List<PostModel> GetAll()
        {
            var post = _context.Post.Select(post
               => new PostModel
               {
                   Id = post.Id,
                   PostTitle = post.PostTitle,
                   TopicId = post.TopicId,
                   Image = post.Image,
                   Status = post.Status
               }).ToList();
            return post;
        }

        public List<PostModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<PostModel> GetByAlias(string alias)
        {
            throw new NotImplementedException();
        }

        public PostModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
