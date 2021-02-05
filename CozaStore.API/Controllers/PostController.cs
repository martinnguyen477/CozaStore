using CozaStore.Model.Model;
using CozaStore.Services.PostServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CozaStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostServices _postServices;

        public PostController(IPostServices postServices)
        {
            _postServices = postServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _postServices.GetAll());
        }

        [HttpPost]
        // GET: api/<PageController>
        public IActionResult Insert([FromBody] PostModel postModel)
        {
            _postServices.InsertPost(postModel);
            return new OkObjectResult(postModel);
        }

        [HttpPut]
        public IActionResult Update([FromBody] PostModel postModel)
        {
            _postServices.UpdatePost(postModel);
            return new OkObjectResult(postModel);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] PostModel postModel)
        {
            var status =await _postServices.DeletePost(postModel.Id);
            return Ok(status);
        }


    } 
}