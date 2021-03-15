// <copyright file="IPostServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.PostServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;
    using CozaStore.Model.ResponseModel;

    public interface IPostServices
    {
        void Add(PostModel postModel);

        void Update(PostModel postModel);

        void Delete(int id);

        ListPosts GetById(int idPost);

        Task<List<ListPosts>> GetPosts();

        Task<PageList<ListPosts>> GetPostsPaging(PagingParameters pagingParameters);

        Task<PageList<ListPosts>> GetsPostsByTopic(PagingParameters pagingParameters, int topicId);

        Task<PageList<ListPosts>> GetLatestPosts(PagingParameters pagingParameters);

        Task<PageList<ListPosts>> SearchPosts(string keyWordSearch, PagingParameters pagingParameters);
    }
}
