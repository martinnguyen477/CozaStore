// <copyright file="ContactServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.Services.Admin.ContactServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AutoMapper;
    using CozaStore.Data.EntityContext;
    using CozaStore.Model.EntitiesModel;
    using CozaStore.Model.Exception;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;

    public class ContactServices : ServicesBase<ContactModel>, IContactServices
    {
        #region Contructor, Variable
        private readonly CozaStoreContext _context;
        private readonly IMapper _mapper;

        public ContactServices(CozaStoreContext context, IMapper mapper)
            : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        #endregion

        public void Add(ContactModel contactModel)
        {
            ContactEntities contact = _mapper.Map<ContactModel, ContactEntities>(contactModel);
            _context.Add(contact);
        }

        public void Delete(int idContact)
        {
            var contact = _context.Contact.Where(c => c.Id == idContact).SingleOrDefault();
            if (contact == null)
            {
                throw new CozaStoreException($"Không tìm thấy liên hệ này{idContact}");
            }

            _context.Remove(idContact);
            _context.SaveChanges();
        }

        public void Update(ContactModel contactModel)
        {
            var contact = _mapper.Map<ContactModel, ContactEntities>(contactModel);
            _context.Contact.Update(contact);
            _context.SaveChanges();
        }

        public ContactModel GetContactById(int idContact)
        {
            var getContact = _mapper.Map<ContactEntities, ContactModel>(_context.Contact.Where(c => c.Id == idContact).SingleOrDefault());

            return getContact;
        }

        public List<ContactModel> GetContacts()
        {
            var contact = _context.Contact.Select(
                c => new ContactModel
                {
                    Id = c.Id,
                    Email = c.Email,
                    FullName = c.FullName,
                    PhoneNumber = c.PhoneNumber,
                    ContactTitle = c.ContactTitle,
                    Message = c.Message,
                    CreateDate = c.CreateDate,
                    Status = c.Status
                }).ToList();
            return contact;
        }

        public Task<PageList<ContactModel>> GetContactsLastest(PagingParameters pagingParameters)
        {
            var contact = _context.Contact.Select(
                c => new ContactModel
                {
                    Id = c.Id,
                    Email = c.Email,
                    FullName = c.FullName,
                    PhoneNumber = c.PhoneNumber,
                    ContactTitle = c.ContactTitle,
                    Message = c.Message,
                    CreateDate = c.CreateDate,
                    Status = c.Status
                }).Where(c => DateTime.Now.Day - c.CreateDate.Day > 7).OrderBy(c => c.Id).ToList();
            var result = PageList<ContactModel>.GetPageList(contact, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }

        public Task<PageList<ContactModel>> GetContactsPaging(PagingParameters pagingParameters)
        {
            var contact = _context.Contact.Select(
                c => new ContactModel
                {
                    Id = c.Id,
                    Email = c.Email,
                    FullName = c.FullName,
                    PhoneNumber = c.PhoneNumber,
                    ContactTitle = c.ContactTitle,
                    Message = c.Message,
                    CreateDate = c.CreateDate,
                    Status = c.Status
                }).ToList();
            var result = PageList<ContactModel>.GetPageList(contact, pagingParameters.PageNumber, pagingParameters.PageSize);
            return Task.FromResult(result);
        }
    }
}
