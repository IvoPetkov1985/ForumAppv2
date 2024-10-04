using ForumAppv2.Infrastructure.Data.Configuration;
using ForumAppv2.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumAppv2.Infrastructure.Data
{
    public class ForumAppv2DbContext : DbContext
    {
        public ForumAppv2DbContext(DbContextOptions<ForumAppv2DbContext> options)
            : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
