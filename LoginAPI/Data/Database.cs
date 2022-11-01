using Microsoft.EntityFrameworkCore;
using UserAPI.Models;

namespace UserAPI.Data
{
    public class Database : DbContext
    {
        //constructure
        public Database(DbContextOptions<Database>options) : base(options) { }

            // คือ dataset ของ User   และชื่อของตาราง database นั้น คือ Users
        public DbSet<User> Users => Set<User>();   
        
    }
}
