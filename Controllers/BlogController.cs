using cloudscribe.SimpleContent.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kemmis_info.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private IBlogService blogService;

        public BlogController(IBlogService blogService)
        {
            this.blogService = blogService;
        }

        [HttpGet("[action]")]
        public List<IPost> GetPosts()
        {
            return blogService.GetPosts(null, 1, false).Result.Data;
        }
    }
}
