using Microsoft.EntityFrameworkCore;

namespace MiniProject_LinkedIn.Models
{
    public class UserContext:DbContext
    {
        public UserContext()
        {

        }
        public UserContext(DbContextOptions<UserContext> options):base (options)
        {
        }
            public DbSet<UserCredentiols> UserCredentiols { get; set; }
    }
}
