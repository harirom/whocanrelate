using Microsoft.EntityFrameworkCore;
using WhoCanRelate.Models;

namespace WhoCanRelate
{
    public class BlogContext : DbContext
    {
        public DbSet<ContentModel> Contents { get; set; }
    }
}
