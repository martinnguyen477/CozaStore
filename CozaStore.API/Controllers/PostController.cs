// <copyright file="PostController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CozaStore.API.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CozaStore.Model.Model;
    using CozaStore.Model.PageResult;
    using CozaStore.Model.ResponseModel;
    using CozaStore.Services.PostServices;
    using Microsoft.AspNetCore.Mvc;

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

        #region GetAll
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _postServices.GetPostsAll());
        }
        #endregion

        #region Add
        [HttpPost]
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
            return new OkObjectResult(postModel);
        }
        #endregion

        #region Delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _postServices.Delete(id);
            return new OkObjectResult(id);
        }
        #endregion

        #region PostById
        [HttpGet("{idPost:int}")]
        public ListPosts PostById(int idPost)
        {
            return _postServices.GetById(idPost);
        }
        #endregion

        #region GetPostsPaging
        [HttpGet("GetPostsPaging")]
        public async Task<ActionResult<IEnumerable<ListPosts>>> GetPostsPaging([FromQuery] PagingParameters pagingParameters)
        {
            return await _postServices.GetPostsPaging(pagingParameters);
        }
        #endregion

        #region GetPostsByTopic
        [HttpGet("GetPostsByTopic")]
        public async Task<ActionResult<IEnumerable<ListPosts>>> GetPostsByTopic([FromQuery] PagingParameters pagingParameters, int topicId)
        {
            return await _postServices.GetsPostsByTopic(pagingParameters, topicId);
        }
        #endregion

        #region SearchProduct
        [HttpGet("SearchProducts")]
        public async Task<ActionResult<IEnumerable<ListPosts>>> SearchProducts([FromQuery] PagingParameters pagingParameters, string keyWordSearch)
        {
            return await _postServices.SearchPosts(keyWordSearch, pagingParameters);
        }
        #endregion

        #region LastestProducts
        [HttpGet("LastestProducts")]
        public async Task<ActionResult<IEnumerable<ListPosts>>> LastestProducts([FromQuery] PagingParameters pagingParameters)
        {
            return await _postServices.GetLatestPosts(pagingParameters);
        }
        #endregion
    }
}