using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Blog;
using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace Annie_sPastryShop.Controllers
{
    public class BlogController : BaseController
    {
        private readonly IBlogService blogService;

        public BlogController(IBlogService _blogService)
        {
            blogService = _blogService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var blogs = await blogService.GetAllBlogsAsync();
            return View(blogs);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var blog = await blogService.GetBlogByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        [HttpGet]
        [Authorize(Roles =ModeratorRoleName)]

        public  IActionResult Create()
        {
            if (!User.IsInRole(ModeratorRoleName))
            {
                return Unauthorized();
            }
            var model= new BlogViewModel();
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles =ModeratorRoleName)]
        public async Task<IActionResult> Create(BlogViewModel model)
        {
            if (!User.IsInRole(ModeratorRoleName))
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await blogService.AddBlogAsync(model);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        [Authorize(Roles =ModeratorRoleName)]
        public async Task<IActionResult> Edit(int id)
        {
            if (!User.IsInRole(ModeratorRoleName))
            {
                return Unauthorized();
            }

            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID");
                }

                var blog = await blogService.GetBlogByIdAsync(id);

                if (blog == null)
                {
                    return NotFound();
                }

                return View(blog);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Authorize(Roles =ModeratorRoleName)]
        public async Task<IActionResult> Edit(int id, BlogViewModel model)
        {
            if (!User.IsInRole(ModeratorRoleName))
            {
                return Unauthorized();
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await blogService.UpdateBlogAsync(model);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            return RedirectToAction(nameof(All));
        }
        [HttpGet]
        [Authorize(Roles = ModeratorRoleName)]
        public async Task<IActionResult> Delete(int id)
        {
            if (!User.IsInRole(ModeratorRoleName))
            {
                return Unauthorized();
            }

            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID");
                }

                var blog = await blogService.GetBlogByIdAsync(id);

                if (blog == null)
                {
                    return NotFound();
                }

                return View(blog);
            }

            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Authorize(Roles = ModeratorRoleName)]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            if (!User.IsInRole(ModeratorRoleName))
            {
                return Unauthorized();
            }

            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid ID");
                }

                await blogService.DeleteBlogAsync(id);
                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
