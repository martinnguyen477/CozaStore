// <copyright file="PostServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.PostServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using CozaStore.Data.EntityContext;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Exception;
    using CozaStore.Model.Model;
    using CozaStore.Model.ResponseModel;
    using CozaStore.Services.PostServices;
    using Microsoft.EntityFrameworkCore;

    public class PostServices : IPostServices
    {
        #region Contructor, Varible Readonly
        private readonly CozaStoreContext _context;
        private readonly IMapper _mapper;

        public PostServices(CozaStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region GetAll
        public async Task<List<PostModel>> GetAll()
        {
            var post = _context.Post.Select(p
               => new PostModel
               {
                   Id = p.Id,
                   PostTitle = p.PostTitle,
                   TopicId = p.TopicId,
                   Image = p.Image,
                   Detail = p.Detail,
                   Status = p.Status
               }).ToListAsync();
            return await post;
        }
        #endregion

        #region Insert Post
        public async Task<int> InsertPost(PostModel postModel)
        {
            PostEntities post = _mapper.Map<PostModel, PostEntities>(postModel);
            _context.Post.Add(post);
            return await _context.SaveChangesAsync();
        }
        #endregion

        #region Update
        public async Task<int> UpdatePost(PostModel postModel)
        {
            PostEntities post = _mapper.Map<PostModel, PostEntities>(postModel);
            _context.Update(post);
            return await _context.SaveChangesAsync();
        }
        #endregion

        #region Delete
        public async Task<int> DeletePost(int postId)
        {
            var post = _context.Post.Find(postId);
            if (post == null)
            {
                throw new CozaStoreException($"Không tìm thấy post{postId}");
            }

            _context.Remove(post);
            return await _context.SaveChangesAsync();
        }
        #endregion

        

        public Task<List<PostModel>> GetAllPaging(string keyword, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostModel>> GetByAlias(string alias)
        {
            throw new NotImplementedException();
        }

        // public async Task<PostResponse> GetById(int postId)
        // {
        //    var topicName = (from p in _context.Post
        //                    join tp in _context.Topic on p.TopicId equals tp.Id
        //                    where p.Id == postId && tp.Id == p.TopicId
        //                    select new PostResponse()
        //                    {
        //                        Id = p.Id,
        //                        PostTitle = p.PostTitle,
        //                        Image = p.Image,
        //                        Detail = p.Detail,
        //                        TopicName = tp.TopicName,
        //                        Status = p.Status,
        //                        CreateDate = p.CreateDate
        //                    }).FirstOrDefault();

        //    // var postVM = new PostResponse()
        //    // {
        //    //    PostId = post.Id,
        //    //    PostTitle = post.PostTitle,
        //    //    Image = post.Image,
        //    //    Detail = post.Detail,
        //    //    TopicName = topicName,
        //    //    Status = post.Status,
        //    //    CreateDate = post.CreateDate
        //    // };
        //    return topicName;
        //}
    }
}
