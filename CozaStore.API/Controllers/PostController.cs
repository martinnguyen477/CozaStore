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

        #region Contructor, Variable
        private readonly IPostServices _postServices;

        public PostController(IPostServices postServices)
        {
            _postServices = postServices;
        }
        #endregion

        #region Add
        [HttpPost]
        // GET: api/<PageController>
        public IActionResult Add([FromBody] PostModel postModel)
        {
            _postServices.Add(postModel);
            return new OkObjectResult(postModel);
        }
        #endregion

        #region Update
        [HttpPut]
        public IActionResult Update([FromBody] PostModel postModel)
        {
            _postServices.Update(postModel);
            _postServices.SaveChanges();
            return new OkObjectResult(postModel);
        }
        #endregion

        #region Delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _postServices.Delete(id);
            _postServices.SaveChanges();
            return new OkObjectResult(id);
        }
        #endregion

        #region GetAll
        [HttpGet]
        public IActionResult Index()
        {
            var model = _postServices.GetAll();

            return new OkObjectResult(model);

        }
        #endregion
    }
}