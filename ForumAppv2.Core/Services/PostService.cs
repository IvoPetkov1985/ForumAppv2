using ForumAppv2.Core.Contracts;
using ForumAppv2.Core.ViewModels.Post;
using ForumAppv2.Infrastructure.Data;
using ForumAppv2.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumAppv2.Core.Services
{
    public class PostService : IPostService
    {
        private readonly ForumAppv2DbContext context;

        public PostService(ForumAppv2DbContext _context)
        {
            context = _context;
        }

        public async Task AddNewPostAsync(PostFormModel model)
        {
            var postToAdd = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            await context.Posts.AddAsync(postToAdd);

            await context.SaveChangesAsync();
        }

        public async Task DeletePostAsync(int id)
        {
            var postToDelete = await context.Posts.FindAsync(id);

            if (postToDelete == null)
            {
                throw new ArgumentException("This post doesn't exist!");
            }

            context.Posts.Remove(postToDelete);

            await context.SaveChangesAsync();
        }

        public async Task EditPostAsync(PostViewModel model)
        {
            var postToEdit = await context.Posts.FindAsync(model.Id);

            if (postToEdit == null)
            {
                throw new ArgumentException("This post doesn't exist!");
            }

            postToEdit.Title = model.Title;
            postToEdit.Content = model.Content;

            await context.SaveChangesAsync();
        }

        public async Task<IList<PostViewModel>> GetAllPostsAsync()
        {
            return await context.Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                })
                .ToListAsync();
        }

        public async Task<PostFormModel> GetPostByIdAsync(int id)
        {
            var postToGet = await context.Posts.FindAsync(id);

            if (postToGet == null)
            {
                throw new ArgumentException("This post doesn't exist!");
            }

            return new PostFormModel()
            {
                Title = postToGet.Title,
                Content = postToGet.Content
            };
        }
    }
}
