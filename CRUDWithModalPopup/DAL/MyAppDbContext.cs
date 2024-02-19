using CRUDWithModalPopup.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithModalPopup.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
