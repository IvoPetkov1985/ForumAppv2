using System.ComponentModel.DataAnnotations;
using static ForumAppv2.Infrastructure.Data.DataConstants.ValidationConstants;

namespace ForumAppv2.Infrastructure.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(PostTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(PostContentMaxLength)]
        public string Content { get; set; } = string.Empty;
    }
}
