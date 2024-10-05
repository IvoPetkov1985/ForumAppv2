using ForumAppv2.Core.ViewModels.Post;
using ForumAppv2.Infrastructure.Data.Models;

namespace ForumAppv2.Core.Contracts
{
    public interface IPostService
    {
        Task<IList<PostViewModel>> GetAllPostsAsync();

        Task AddNewPostAsync(PostFormModel model);

        Task<PostFormModel> GetPostByIdAsync(int id);

        Task EditPostAsync(PostViewModel model);

        Task DeletePostAsync(int id);
    }
}
