using Microsoft.EntityFrameworkCore;
using TreeOfLife.Models;

namespace TreeOfLife.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TreeNode> TreeNodes { get; set; }
    }
}
