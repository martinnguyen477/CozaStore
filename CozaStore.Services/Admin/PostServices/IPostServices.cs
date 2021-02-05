// <copyright file="IPostServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.PostServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CozaStore.Model.Model;

    public interface IPostServices
    {
        void Add(PostModel postModel);

        void Update(PostModel postModel);

        void Delete(int id);

        List<PostModel> GetAll();

        List<PostModel> GetAllPaging(string keyword, int page, int pageSize);

        List<PostModel> GetByAlias(string alias);

        PostModel GetById(int id);

        void SaveChanges();
    }
}
