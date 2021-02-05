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
    using CozaStore.Model.ResponseModel;

    public interface IPostServices
    {
        Task<int> InsertPost(PostModel postModel);

        Task<int> UpdatePost(PostModel postModel);

        Task<int> DeletePost(int postId);

        Task<List<PostModel>> GetAll();

        Task<List<PostModel>> GetAllPaging(string keyword, int page, int pageSize);

        Task<List<PostModel>> GetByAlias(string alias);

        // Task<PostResponse> GetById(int postId);
    }
}
