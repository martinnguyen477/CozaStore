// <copyright file="IContactServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.Admin.ContactServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;

    public interface IContactServices
    {
        void Add(ContactModel contactModel);

        void Update(ContactModel contactModel);

        void Delete(int idContact);

        ContactModel GetContactById(int idContact);

        List<ContactModel> GetContacts();

        Task<PageList<ContactModel>> GetContactsPaging(PagingParameters pagingParameters);

        Task<PageList<ContactModel>> GetContactsLastest(PagingParameters pagingParameters);
    }
}
