using ForumAppv2.Core.Contracts;
using ForumAppv2.Core.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;

namespace ForumAppv2.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService service;

        public PostController(IPostService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await service.GetAllPostsAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await service.AddNewPostAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var postToEdit = await service.GetPostByIdAsync(id);

            return View(postToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await service.EditPostAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await service.DeletePostAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
