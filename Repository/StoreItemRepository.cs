using easy_groceries_backend.Data;
using easy_groceries_backend.Data.Entities;

namespace easy_groceries_backend.Repository
{
    public class StoreItemRepository : IStoreItemRepository
    {
        private readonly EasyGroceryContext _dbContext;
        public StoreItemRepository(EasyGroceryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<StoreItem> GetStoreItem()
        {
            return _dbContext.StoreItem.ToList();          
        }
    }
}
