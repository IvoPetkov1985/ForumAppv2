using System.ComponentModel.DataAnnotations;
using static ForumAppv2.Infrastructure.Data.DataConstants.ValidationConstants;

namespace ForumAppv2.Core.ViewModels.Post
{
    public class PostFormModel
    {
        [Required(ErrorMessage = RequiredWarning)]
        [StringLength(PostTitleMaxLength, MinimumLength = PostTitleMinLength, ErrorMessage = LengthWarning)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredWarning)]
        [StringLength(PostContentMaxLength, MinimumLength = PostContentMinLength, ErrorMessage = LengthWarning)]
        public string Content { get; set; } = string.Empty;
    }
}
