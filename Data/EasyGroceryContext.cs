using easy_groceries_backend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace easy_groceries_backend.Data
{
    public class EasyGroceryContext : DbContext
    {
        public EasyGroceryContext(DbContextOptions<EasyGroceryContext> context) : base(context)
        {
        }
        public DbSet<StoreItem> StoreItem { get; set; }
    }
}
