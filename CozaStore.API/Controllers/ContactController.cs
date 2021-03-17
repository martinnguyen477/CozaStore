// <copyright file="ContactController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CozaStore.Model.Model;
    using CozaStore.Services.Admin.ContactServices;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactServices _contactServices;

        public ContactController(IContactServices contactServices)
        {
            _contactServices = contactServices;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_contactServices.GetContacts());
        }
    }
}
