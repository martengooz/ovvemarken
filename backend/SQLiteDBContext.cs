using Microsoft.EntityFrameworkCore;
using ovvemarken_backend.Models;

namespace ovvemarken_backend
{
    public class SQLiteDBContext : DbContext
    {
        public DbSet<PatchModel> Patches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=ovvemarken.db");
    }
}
